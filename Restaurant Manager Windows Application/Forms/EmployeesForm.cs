using Entities;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application
{
    public partial class EmployeesForm : MetroForm
    {

        private Restaurant restaurant = MainForm.Restaurant;
        private new MainForm Owner;

        public EmployeesForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            
            metroDateTime2.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month,DateTime.Now.Day);

            //values for position combobox initialization
            metroComboBox2.Items.Add("Bartender");
            metroComboBox2.Items.Add("Chef");
            metroComboBox2.Items.Add("Cook");
            metroComboBox2.Items.Add("Dishwasher");
            metroComboBox2.Items.Add("Restaurant Manager");
            metroComboBox2.Items.Add("Waiter");

        }

        #region Add button with validation
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(metroTextBox6.Text.Trim()))
            {
                valid = false;
                errorProvider1.SetError(metroTextBox6, "First name cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(metroTextBox6, null);
                newEmployee.FirstName = metroTextBox6.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(metroTextBox5.Text.Trim()))
            {
                valid = false;
                errorProvider2.SetError(metroTextBox5, "Last name cannot be empty!");
            }
            else
            {
                errorProvider2.SetError(metroTextBox5, null);
                newEmployee.LastName = metroTextBox5.Text.Trim();
            }

            newEmployee.Birthdate = metroDateTime2.Value.ToString("D");

            if (metroRadioButton4.Checked)
            {
                newEmployee.Gender = "Male";
                errorProvider3.SetError(metroPanel2, null);
            }
            else if (metroRadioButton3.Checked)
            {
                newEmployee.Gender = "Female";
                errorProvider3.SetError(metroPanel2, null);
            }
            else
            {
                valid = false;
                errorProvider3.SetError(metroPanel2, "No gender selected!");
            }

            if (string.IsNullOrEmpty(metroComboBox2.Text))
            {
                errorProvider4.SetError(metroComboBox2, "No position selected!");
                valid = false;
            }
            else
            {
                errorProvider4.SetError(metroComboBox2, null);
                newEmployee.Position = metroComboBox2.Text;
            }

            if (string.IsNullOrWhiteSpace(metroTextBox4.Text.Trim()))
            {
                valid = false;
                errorProvider5.SetError(metroTextBox4, "Wage cannot be empty!\n");
            }
            else
            {
                try
                {
                    errorProvider5.SetError(metroTextBox4, null);
                    int wage = Convert.ToInt32(metroTextBox4.Text);
                    if (wage < 0)
                    {
                        valid = false;
                        errorProvider5.SetError(metroTextBox4, "The wage must be positive!");
                    }
                    newEmployee.Wage = wage;
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider5.SetError(metroTextBox4, "Invalid number!");
                }
            }

            if(valid)
            {
                restaurant.Employee.Add(newEmployee);
                bindToDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #endregion

        #region Event Load Form
        private void Employees_Load(object sender, EventArgs e)
        {
            bindToDataGrid();
        }

        #endregion

        #region Event Close Form
        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
        #endregion

        void bindToDataGrid()
        {
            var list = new BindingList<Employee>(restaurant.Employee);
            metroGrid2.DataSource = list;
            metroGrid2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
