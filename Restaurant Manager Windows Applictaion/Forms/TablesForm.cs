using Entities;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application.Forms
{
    public partial class TablesForm : MetroForm
    {
        private new MetroForm Owner = null;
        private Restaurant restaurant = MainForm.Restaurant;
        public TablesForm()
        {
            InitializeComponent();
            tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
        }
        public TablesForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
        }
        public TablesForm(ReservationsForm owner)
        {
            Owner = owner;
            InitializeComponent();
            tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
        }

        private void TablesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
                Owner.Show();
        }

        #region Add button event with validation
        private void metroButton1_Click(object sender, EventArgs e)
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
                addTable(table);
                tableNumberTextBox.Text = (restaurant.Tables.Count+1).ToString();
                bindDataToGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void TablesForm_Load(object sender, EventArgs e)
        {
            bindDataToGrid();
        }

        void bindDataToGrid()
        {
            var list = new BindingList<Tables>(restaurant.Tables);
            metroGrid.DataSource = list;
            metroGrid.Columns["Id"].ReadOnly = true;
            metroGrid.Columns["Number"].ReadOnly = true;
            metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void addTable(Tables table)
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //If i have tables i get the one selected and delete it from database and datastructure
            if (restaurant.Tables.Count == 0)
            {
                MetroMessageBox.Show(this, "\nThere are no tables to delete!", "Deleting Tables", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "\nAre you sure you want to delete the table?", "Deleting Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Tables SET MaxSeats = "+ metroGrid.SelectedRows[0].Cells["MaxSeats"].Value + " WHERE Id=" + metroGrid.SelectedRows[0].Cells["Id"].Value, connection);
            cmd.ExecuteNonQuery();
            bindDataToGrid();
            connection.Close();
        }

        private void metroGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int a;
            if (!int.TryParse(e.FormattedValue.ToString(), out a))
            {
                MetroMessageBox.Show(this, "\nValue must be a number!", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
