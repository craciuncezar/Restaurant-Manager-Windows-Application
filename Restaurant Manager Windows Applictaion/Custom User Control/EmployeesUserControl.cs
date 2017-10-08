using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities;
using Restaurant_Manager_Windows_Application;
using MetroFramework;
using System.Data.SQLite;

namespace Restaurant_Manager_Windows_Applictaion.Custom_User_Control
{
    public partial class EmployeesUserControl : UserControl
    {

        private Restaurant restaurant = MainForm.Restaurant;
        private Employee employeeToEdit = null;

        public EmployeesUserControl()
        {
            InitializeComponent();

            birthDateTime.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);

            //values for position combobox initialization
            positionComboBox.Items.Add("Bartender");
            positionComboBox.Items.Add("Chef");
            positionComboBox.Items.Add("Cook");
            positionComboBox.Items.Add("Dishwasher");
            positionComboBox.Items.Add("Restaurant Manager");
            positionComboBox.Items.Add("Waiter");
        }

        #region Events

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();

            if (formValidation(newEmployee))
            {
                addEmployeeToDB(newEmployee);
                resetFields();
                MetroMessageBox.Show(MainForm.ActiveForm, "\nEmployee was added succesfully!", "Employee added", MessageBoxButtons.OK, MessageBoxIcon.None);
                metroTabControl1.SelectedIndex = 0;
            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //If i have employees i get the one selected and delete it from database and datastructure
            if (restaurant.Employee.Count == 0)
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nThere are no employees to delete!", "Deleting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(MainForm.ActiveForm, "\nAre you sure you want to delete this employee?", "Deleting Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteEmployeeDB();

                    foreach (Employee emp in restaurant.Employee)
                    {
                        if (emp.Id == (long)metroGrid2.SelectedRows[0].Cells["Id"].Value)
                        {
                            restaurant.Employee.Remove(emp);
                            break;
                        }
                    }
                    bindToDataGrid();
                }
            }
        }

        private void edit2Btn_Click(object sender, EventArgs e)
        {
            if (restaurant.Employee.Count == 0)
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nThere is no employee selected to edit!", "No employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //get the employee selected
                employeeToEdit = new Employee();
                foreach (Employee emp in restaurant.Employee)
                {
                    if (emp.Id == ((long)metroGrid2.SelectedRows[0].Cells["Id"].Value))
                    {
                        employeeToEdit = emp;
                        restaurant.Employee.Remove(emp);
                        break;
                    }
                }

                //change tab
                metroTabControl1.SelectedIndex = 1;
                metroTabPage1.Text = "Edit employee";

                //fill fields with employee's data 
                firstNameTextBox.Text = employeeToEdit.FirstName;
                lastNameTextBox.Text = employeeToEdit.LastName;
                birthDateTime.Value = DateTime.ParseExact(employeeToEdit.Birthdate, "D", null);
                positionComboBox.SelectedIndex = positionComboBox.FindStringExact(employeeToEdit.Position.ToString());
                wageTextBox.Text = employeeToEdit.Wage.ToString();
                if (employeeToEdit.Gender.Equals("Male"))
                {
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                }
                else
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                }

                //display the edit button
                addEmployeeBtn.Visible = false;
                cancelEditBtn.Visible = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();

            if (formValidation(newEmployee))
            {
                newEmployee.Id = employeeToEdit.Id;
                restaurant.Employee.Add(newEmployee);
                updateEmployeeDB(newEmployee);

                resetFields();
                addEmployeeBtn.Visible = true;
                cancelEditBtn.Visible = false;
                metroTabPage1.Text = "Add New Employee";

                MetroMessageBox.Show(MainForm.ActiveForm, "\nEmployee was edited succesfully!", "Employee Edited", MessageBoxButtons.OK, MessageBoxIcon.None);

                employeeToEdit = null;
                metroTabControl1.SelectedIndex = 0;

            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            restaurant.Employee.Add(employeeToEdit);
            resetFields();
            addEmployeeBtn.Visible = true;
            cancelEditBtn.Visible = false;
            metroTabPage1.Text = "Add New Employee";
            employeeToEdit = null;
            metroTabControl1.SelectedIndex = 0;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindToDataGrid();
            if (employeeToEdit != null && metroTabControl1.SelectedIndex == 0)
            {
                metroTabControl1.SelectedIndex = 1;
                MetroMessageBox.Show(MainForm.ActiveForm, "\nPlease edit the employee before changing the tab!", "Employee edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EmployeesUserControl_VisibleChanged(object sender, EventArgs e)
        {
            bindToDataGrid();
        }

        #endregion

        #region Methods

        void bindToDataGrid()
        {
            var list = new BindingList<Employee>(restaurant.Employee);
            metroGrid2.DataSource = list;
            metroGrid2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private bool formValidation(Employee newEmployee)
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text.Trim()) || (firstNameTextBox.Text.Length < 3))
            {
                valid = false;
                errorProvider1.SetError(firstNameTextBox, "First name must have atleast 3 characters!");
            }
            else
            {
                errorProvider1.SetError(firstNameTextBox, null);
                newEmployee.FirstName = firstNameTextBox.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text.Trim()) || (lastNameTextBox.Text.Length < 3))
            {
                valid = false;
                errorProvider2.SetError(lastNameTextBox, "Last name  must have atleast 3 characters!");
            }
            else
            {
                errorProvider2.SetError(lastNameTextBox, null);
                newEmployee.LastName = lastNameTextBox.Text.Trim();
            }

            newEmployee.Birthdate = birthDateTime.Value.ToString("D");

            if (maleRadioButton.Checked)
            {
                newEmployee.Gender = "Male";
                errorProvider3.SetError(metroPanel2, null);
            }
            else if (femaleRadioButton.Checked)
            {
                newEmployee.Gender = "Female";
                errorProvider3.SetError(metroPanel2, null);
            }
            else
            {
                valid = false;
                errorProvider3.SetError(metroPanel2, "No gender selected!");
            }

            if (string.IsNullOrEmpty(positionComboBox.Text))
            {
                errorProvider4.SetError(positionComboBox, "No position selected!");
                valid = false;
            }
            else
            {
                errorProvider4.SetError(positionComboBox, null);
                newEmployee.Position = positionComboBox.Text;
            }

            if (string.IsNullOrWhiteSpace(wageTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider5.SetError(wageTextBox, "Wage cannot be empty!\n");
            }
            else
            {
                try
                {
                    errorProvider5.SetError(wageTextBox, null);
                    double wage = double.Parse(wageTextBox.Text);
                    if (wage < 0)
                    {
                        valid = false;
                        errorProvider5.SetError(wageTextBox, "The wage must be positive!");
                    }
                    newEmployee.Wage = wage;
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider5.SetError(wageTextBox, "Invalid number!");
                }
            }

            return valid;
        }

        private void resetFields()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            birthDateTime.Value = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            positionComboBox.SelectedIndex = -1;
            wageTextBox.Text = "";
        }

        private void addEmployeeToDB(Employee employee)
        {
            var queryString = "insert into Employees(FirstName, LastName, Wage, Position, Birthdate, Gender)" +
                              " values(@FirstName,@LastName,@Wage,@Position,@Birthdate,@Gender);  " +
                              "SELECT last_insert_rowid()";

            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();

            var command = new SQLiteCommand(queryString, connection);
            var firstNameParameter = new SQLiteParameter("@FirstName");
            firstNameParameter.Value = employee.FirstName;
            var lastNameParameter = new SQLiteParameter("@LastName");
            lastNameParameter.Value = employee.LastName;
            var wageParameter = new SQLiteParameter("@Wage");
            wageParameter.Value = employee.Wage;
            var positionParameter = new SQLiteParameter("@Position");
            positionParameter.Value = employee.Position;
            var birthDateParameter = new SQLiteParameter("@Birthdate");
            birthDateParameter.Value = employee.Birthdate;
            var genderParameter = new SQLiteParameter("@Gender");
            genderParameter.Value = employee.Gender;

            command.Parameters.Add(firstNameParameter);
            command.Parameters.Add(lastNameParameter);
            command.Parameters.Add(wageParameter);
            command.Parameters.Add(positionParameter);
            command.Parameters.Add(birthDateParameter);
            command.Parameters.Add(genderParameter);

            employee.Id = (long)command.ExecuteScalar();

            restaurant.Employee.Add(employee);

            connection.Close();

        }

        private void deleteEmployeeDB()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Employees WHERE Id=" + metroGrid2.SelectedRows[0].Cells["Id"].Value, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void updateEmployeeDB(Employee employeeToEdit)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Employees SET FirstName ='" + employeeToEdit.FirstName + "' , LastName = '" + employeeToEdit.LastName + "' , Wage = " + employeeToEdit.Wage + " , Position = '" + employeeToEdit.Position + "' , Birthdate = '" + employeeToEdit.Birthdate + "', Gender = '" + employeeToEdit.Gender + "' WHERE Id=" + employeeToEdit.Id, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        #endregion
    }
}
