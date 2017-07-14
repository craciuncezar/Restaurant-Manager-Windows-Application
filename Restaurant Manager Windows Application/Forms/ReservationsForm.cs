using Entities;
using MetroFramework;
using MetroFramework.Forms;
using Restaurant_Manager_Windows_Application.Forms;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application
{
    public partial class ReservationsForm : MetroForm
    {

        private new MainForm Owner;
        private Restaurant restaurant = MainForm.Restaurant;

        public ReservationsForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();

            metroDateTime.MinDate = DateTime.Now;
            checkFreeTables();

            if (restaurant.Tables.Count == 0)
                panel2.Visible = false;
        }



        #region Close form event
        private void ReservationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
        #endregion

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider1.SetError(nameTextBox, "Name cannot be empty!");
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
                    int number = Convert.ToInt32(phoneNumberTextBox.Text.Trim());
                    errorProvider5.SetError(phoneNumberTextBox, null);
                    reservation.PhoneNumber = number;
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider5.SetError(phoneNumberTextBox, "Invalid number!");
                }
            }

            if (valid)
            {
                addReservation(reservation);
                bindToDataGrid();
                clearValuesForm();
                checkFreeTables();
                MetroMessageBox.Show(this, "\nReservation was created succesfully!", "Reservation Created", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                MetroMessageBox.Show(this, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void bindToDataGrid()
        {
            var list = new BindingList<Reservation>(restaurant.Reservations);
            metroGrid1.DataSource = list;
            metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            metroGrid1.Refresh();
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            bindToDataGrid();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablesForm tf = new TablesForm(this);
            tf.ShowDialog();
            if (restaurant.Tables.Count != 0)
            {
                panel2.Visible = true;
                checkFreeTables();
            }
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
            metroDateTime.Value = DateTime.Now;
        }

        public int availableSpace()
        {
            int s = 0;
            foreach (var t in tablesComboBox.Items)
            {
                s += int.Parse(t.ToString());
            }
            return s;
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

        private void addReservation(Reservation reservation)
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
            if (!String.IsNullOrEmpty(guestsTextBox.Text))
            {
                foreach (Tables t in restaurant.Tables)
                {
                    if (tablesComboBox.Text.ToString().Equals(t.Number.ToString()) && int.Parse(guestsTextBox.Text) > t.MaxSeats)
                    {
                        warningText.Text = "Table has " + t.MaxSeats + " available seats!";
                    }
                    else
                        warningText.Text = "";
                }
            }
        }

    }
}
