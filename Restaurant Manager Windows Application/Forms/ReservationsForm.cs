using Entities;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
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

            foreach (Tables t in restaurant.Tables)
            {
                tablesComboBox.Items.Add(t.Number);
            }
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
                restaurant.Reservations.Add(reservation);
                bindToDataGrid();
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
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            bindToDataGrid();
        }
    }
}
