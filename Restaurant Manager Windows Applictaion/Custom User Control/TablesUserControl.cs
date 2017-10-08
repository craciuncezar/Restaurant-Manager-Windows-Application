using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Restaurant_Manager_Windows_Application;
using System.Data.SQLite;
using Entities;

namespace Restaurant_Manager_Windows_Applictaion.Custom_User_Control
{
    public partial class TablesUserControl : UserControl
    {
        private Restaurant restaurant = MainForm.Restaurant;

        public TablesUserControl()
        {
            InitializeComponent();
        }

        #region Events

        private void addBtn_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(maxSeatsTextBox.Text.Trim()))
            {
                errorProvider1.SetError(maxSeatsTextBox, "Please insert a value!");
                valid = false;
            }
            else
            {
                try
                {
                    int maxSeats = Convert.ToInt32(maxSeatsTextBox.Text.Trim());
                    errorProvider1.SetError(maxSeatsTextBox, null);
                    table.MaxSeats = maxSeats;
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider1.SetError(maxSeatsTextBox, "Invalid number!");
                }
            }
            table.Number = Convert.ToInt32(tableNumberTextBox.Text);

            if (valid)
            {
                addTableToDB(table);
                tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
                bindDataToGrid();
            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //If i have tables i get the one selected and delete it from database and datastructure
            if (restaurant.Tables.Count == 0)
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nThere are no tables to delete!", "Deleting Tables", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(MainForm.ActiveForm, "\nAre you sure you want to delete the table?", "Deleting Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
                    connection.Open();

                    SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Tables WHERE Id=" + metroGrid.SelectedRows[0].Cells["Id"].Value, connection);
                    cmd.ExecuteNonQuery();
                    foreach (Tables t in restaurant.Tables)
                    {
                        if (t.Id == (long)metroGrid.SelectedRows[0].Cells["Id"].Value)
                        {
                            restaurant.Tables.Remove(t);
                            break;
                        }
                    }
                    bindDataToGrid();
                    tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
                    connection.Close();
                }
            }
        }

        private void metroGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Tables SET MaxSeats = " + metroGrid.SelectedRows[0].Cells["MaxSeats"].Value + " WHERE Id=" + metroGrid.SelectedRows[0].Cells["Id"].Value, connection);
            cmd.ExecuteNonQuery();
            bindDataToGrid();
            connection.Close();
        }

        private void metroGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int a;
            if (!int.TryParse(e.FormattedValue.ToString(), out a))
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nValue must be a number!", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void TablesUserControl_VisibleChanged(object sender, EventArgs e)
        {
            bindDataToGrid();
            tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
        }

        #endregion

        #region Methods

        void bindDataToGrid()
        {
            var list = new BindingList<Tables>(restaurant.Tables);
            metroGrid.DataSource = list;
            metroGrid.Columns["Id"].ReadOnly = true;
            metroGrid.Columns["Number"].ReadOnly = true;
            metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void addTableToDB(Tables table)
        {
            var queryString = "insert into Tables(Number, MaxSeats)" +
                              " values(@Number,@MaxSeats);  " +
                              "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();

                //1. Add the new participant to the database
                var command = new SQLiteCommand(queryString, connection);
                var numberParameter = new SQLiteParameter("@Number");
                numberParameter.Value = table.Number;
                var maxSeatsParameter = new SQLiteParameter("@MaxSeats");
                maxSeatsParameter.Value = table.MaxSeats;

                command.Parameters.Add(numberParameter);
                command.Parameters.Add(maxSeatsParameter);

                table.Id = (long)command.ExecuteScalar();

                //2. Add the new participants to the local collection
                restaurant.Tables.Add(table);
            }
        }

        #endregion
    }
}

