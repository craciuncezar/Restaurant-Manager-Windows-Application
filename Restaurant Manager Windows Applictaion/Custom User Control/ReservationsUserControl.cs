using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Entities;
using Restaurant_Manager_Windows_Application;
using System.Data.SQLite;
using MetroFramework;
using System.Collections.Generic;

namespace Restaurant_Manager_Windows_Applictaion.Forms
{
    public partial class ReservationsUserControl : UserControl
    {
        private Restaurant restaurant;
        private Reservation reservationToEdit = null;

        public ReservationsUserControl()
        {
            InitializeComponent();
            restaurant = MainForm.Restaurant;
        }


        private void ReservationsUserControl_VisibleChanged(object sender, EventArgs e)
        {
            bindToDataGrid();
            //Min date for reservation time is current date
            metroDateTime.MinDate = DateTime.Now;
            //Check if there are any free tables for the selected date
            checkFreeTables();
            //If there aro no tables created display panel with message and button to add table
            if (restaurant.Tables.Count == 0)
                panel2.Visible = false;
            else
                panel2.Visible = true;
        }

        private void metroDateTime_ValueChanged(object sender, EventArgs e)
        {
            checkFreeTables();
        }

        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAvailableSeats();
        }

        private void guestsTextBox_Validating(object sender, CancelEventArgs e)
        {
            checkAvailableSeats();
        }

        private void AddReservationButton_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            if (formValidation(reservation))
            {
                addReservationToDB(reservation);
                clearValuesForm();
                checkFreeTables();
                MetroMessageBox.Show(MainForm.ActiveForm, "\nReservation was created succesfully!", "Reservation Created", MessageBoxButtons.OK, MessageBoxIcon.None);
                metroTabControl1.SelectedIndex = 0;
            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //If i have reservations i get the one selected and delete it from database and datastructure
            if (restaurant.Reservations.Count == 0)
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nThere are no reservations to delete!", "Deleting Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(MainForm.ActiveForm, "\nAre you sure you want to delete the reservation?", "Deleting Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                    if (sender == deleteButton)
                    {
                        deleteReservationFromDB((long)metroGrid1.SelectedRows[0].Cells["Id"].Value);
                        deleteReservationFromDS((long)metroGrid1.SelectedRows[0].Cells["Id"].Value);

                    }
                    else if (sender == tdaydeleteButton)
                    {
                        deleteReservationFromDB((long)metroGrid2.SelectedRows[0].Cells["Id"].Value);
                        deleteReservationFromDS((long)metroGrid2.SelectedRows[0].Cells["Id"].Value);
                    }
                    bindToDataGrid();
                }
            }
        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkFreeTables();
            bindToDataGrid();
            if (reservationToEdit != null && (metroTabControl1.SelectedIndex == 0 || metroTabControl1.SelectedIndex == 1))
            {
                metroTabControl1.SelectedIndex = 2;
                MetroMessageBox.Show(MainForm.ActiveForm, "\nPlease edit the reservation before changing the tab!", "Reservation edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //the buttons from the all reservations and today reservations tab
        private void editButton_Click(object sender, EventArgs e)
        {
            //get the reservation selected
            if (sender == editButton)
            {
                foreach (Reservation r in restaurant.Reservations)
                {
                    if (r.Id == ((long)metroGrid1.SelectedRows[0].Cells["Id"].Value))
                    {
                        reservationToEdit = r;
                        restaurant.Reservations.Remove(r);
                        break;
                    }
                }
            }
            else if (sender == todayEditButton)
            {
                foreach (Reservation r in restaurant.Reservations)
                {
                    if (r.Id == ((long)metroGrid2.SelectedRows[0].Cells["Id"].Value))
                    {
                        reservationToEdit = r;
                        restaurant.Reservations.Remove(r);
                        break;
                    }
                }
            }

            //change tab
            metroTabControl1.SelectedIndex = 2;
            metroTabPage1.Text = "Edit reservation";

            //fill fields with reservation's data 
            nameTextBox.Text = reservationToEdit.Name;
            guestsTextBox.Text = reservationToEdit.NoPers.ToString();
            metroDateTime.MinDate = DateTime.ParseExact(reservationToEdit.Date, "D", null);
            metroDateTime.Value = DateTime.ParseExact(reservationToEdit.Date, "D", null);
            tablesComboBox.SelectedIndex = tablesComboBox.FindStringExact(reservationToEdit.TableNo.ToString());
            phoneNumberTextBox.Text = reservationToEdit.PhoneNumber.ToString();
            if (reservationToEdit.Email.Equals("no email"))
            {
                emailTextBox.Text = "";
            }
            else
                emailTextBox.Text = reservationToEdit.Email;

            //display the edit button
            AddReservationButton.Visible = false;

        }

        //the button from the edit reservation tab
        private void editButton1_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            if (formValidation(reservation))
            {
                reservation.Id = reservationToEdit.Id;
                restaurant.Reservations.Add(reservation);

                updateReservationDB(reservation);

                clearValuesForm();
                AddReservationButton.Visible = true;
                metroTabPage1.Text = "Add New Reservation";
                MetroMessageBox.Show(MainForm.ActiveForm, "\nReservation was edited succesfully!", "Reservation Edited", MessageBoxButtons.OK, MessageBoxIcon.None);
                reservationToEdit = null;
                metroTabControl1.SelectedIndex = 0;

            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #region Functions

        void bindToDataGrid()
        {
            //all reservations bind
            var list = new BindingList<Reservation>(restaurant.Reservations);
            metroGrid1.DataSource = list;
            metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //today's reservation grid bind
            var listToday = new List<Reservation>();
            foreach(Reservation r in restaurant.Reservations)
            {
                if (r.Date.Equals(DateTime.Today.ToString("D")))
                    listToday.Add(r);
            }
            metroGrid2.DataSource = listToday;
            metroGrid2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void checkFreeTables()
        {
            tablesComboBox.Items.Clear();
            foreach (Tables t in restaurant.Tables)
            {
                if (restaurant.Reservations.Count == 0)
                    tablesComboBox.Items.Add(t.Number);
                else
                {
                    bool isvalid = true;
                    foreach (Reservation r in restaurant.Reservations)
                    {
                        if (r.Date.Equals(metroDateTime.Value.ToString("D")) && r.TableNo == t.Number)
                            isvalid = false;
                    }

                    if (isvalid)
                        tablesComboBox.Items.Add(t.Number);
                }
            }

            if (tablesComboBox.Items.Count == 0)
                warningText.Text = "No free tables for this date!";
            else
                warningText.Text = "";

        }

        public void clearValuesForm()
        {
            emailTextBox.Text = "";
            nameTextBox.Text = "";
            guestsTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            tablesComboBox.SelectedItem = null;
            metroDateTime.MinDate = DateTime.Now;
            metroDateTime.Value = DateTime.Now;
        }

        private void addReservationToDB(Reservation reservation)
        {
            var queryString = "insert into Reservations(Name, Date, NoPers, TableNo, Email, PhoneNumber)" +
                              " values(@name,@date,@noPers,@tableNo,@email,@phoneNumber);  " +
                              "SELECT last_insert_rowid()";

            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();

            var command = new SQLiteCommand(queryString, connection);
            var nameParameter = new SQLiteParameter("@name");
            nameParameter.Value = reservation.Name;
            var dateParameter = new SQLiteParameter("@date");
            dateParameter.Value = reservation.Date;
            var noPersParameter = new SQLiteParameter("@noPers");
            noPersParameter.Value = reservation.NoPers;
            var tableNoParameter = new SQLiteParameter("@tableNo");
            tableNoParameter.Value = reservation.TableNo;
            var emailParameter = new SQLiteParameter("@email");
            emailParameter.Value = reservation.Email;
            var phoneNumberParameter = new SQLiteParameter("@phoneNumber");
            phoneNumberParameter.Value = reservation.PhoneNumber;

            command.Parameters.Add(nameParameter);
            command.Parameters.Add(dateParameter);
            command.Parameters.Add(noPersParameter);
            command.Parameters.Add(tableNoParameter);
            command.Parameters.Add(emailParameter);
            command.Parameters.Add(phoneNumberParameter);

            reservation.Id = (long)command.ExecuteScalar();

            restaurant.Reservations.Add(reservation);

            connection.Close();

        }

        private void checkAvailableSeats()
        {
            int a;
            bool available = true;
            if (!String.IsNullOrEmpty(guestsTextBox.Text) && int.TryParse(guestsTextBox.Text, out a))
            {
                foreach (Tables t in restaurant.Tables)
                {
                    if (tablesComboBox.Text.ToString().Equals(t.Number.ToString()) && a > t.MaxSeats)
                    {
                        available = false;
                        warningText.Text = "Table has " + t.MaxSeats + " available seats!";
                    }
                }
                if (available)
                {
                    warningText.Text = "";
                }
            }
        }

        private bool formValidation(Reservation reservation)
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text.Trim()) && (nameTextBox.Text.Length < 3))
            {
                valid = false;
                errorProvider1.SetError(nameTextBox, "Name must have at least 3 characters!");
            }
            else
            {
                errorProvider1.SetError(nameTextBox, null);
                reservation.Name = nameTextBox.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(guestsTextBox.Text.Trim()))
            {
                errorProvider2.SetError(guestsTextBox, "Please insert a value!");
                valid = false;
            }
            else
            {
                try
                {
                    int guests = Convert.ToInt32(guestsTextBox.Text.Trim());
                    errorProvider2.SetError(guestsTextBox, null);
                    reservation.NoPers = guests;
                    foreach (Tables t in restaurant.Tables)
                    {
                        if (tablesComboBox.Text.ToString().Equals(t.Number.ToString()) && int.Parse(guestsTextBox.Text) > t.MaxSeats)
                        {
                            errorProvider2.SetError(guestsTextBox, "Table has " + t.MaxSeats + " available seats!");
                            valid = false;
                        }
                    }
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider2.SetError(guestsTextBox, "Invalid number!");
                }
            }

            if (string.IsNullOrEmpty(tablesComboBox.Text))
            {
                errorProvider3.SetError(tablesComboBox, "No table selected!");
                valid = false;
            }
            else
            {
                errorProvider3.SetError(tablesComboBox, null);
                reservation.TableNo = int.Parse(tablesComboBox.Text);
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                reservation.Email = "no email";
            }
            else
            {
                System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (expr.IsMatch(emailTextBox.Text))
                {
                    reservation.Email = emailTextBox.Text;
                    errorProvider4.SetError(emailTextBox, null);
                }
                else
                {
                    valid = false;
                    errorProvider4.SetError(emailTextBox, "Invalid email adress!");
                }
            }
            reservation.Date = metroDateTime.Value.ToString("D");
            if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text.Trim()))
            {
                errorProvider5.SetError(phoneNumberTextBox, "Please insert a value!");
                valid = false;
            }
            else
            {
                try
                {
                    long number = long.Parse(phoneNumberTextBox.Text.Trim());
                    if (number.ToString().Length < 9)
                    {
                        errorProvider5.SetError(phoneNumberTextBox, "Number should have at least 10 digits!");
                        valid = false;
                    }
                    else
                    {
                        errorProvider5.SetError(phoneNumberTextBox, null);
                        reservation.PhoneNumber = number;
                    }
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider5.SetError(phoneNumberTextBox, "Invalid number!");
                }
            }

            return valid;
        }

        private void deleteReservationFromDB(long id)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Reservations WHERE Id=" + id, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void deleteReservationFromDS(long id)
        {
            foreach (Reservation r in restaurant.Reservations)
            {
                if (r.Id == id)
                {
                    restaurant.Reservations.Remove(r);
                    break;
                }
            }
        }

        private void updateReservationDB(Reservation reservationToEdit)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Reservations SET Name = '" + reservationToEdit.Name + "' , Date = '" + reservationToEdit.Date + "' , NoPers = " + reservationToEdit.NoPers + " , TableNo = " + reservationToEdit.TableNo + " , Email = '" + reservationToEdit.Email + "', PhoneNumber = " + reservationToEdit.PhoneNumber + " WHERE Id = " + reservationToEdit.Id, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        #endregion Functions

    }
}
