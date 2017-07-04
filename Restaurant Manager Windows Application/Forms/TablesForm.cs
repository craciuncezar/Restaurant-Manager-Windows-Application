using Entities;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application.Forms
{
    public partial class TablesForm : MetroForm
    {
        private new MainForm Owner;
        private Restaurant restaurant = MainForm.Restaurant;

        public TablesForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            tableNumberTextBox.Text = (restaurant.Tables.Count + 1).ToString();
        }

        private void TablesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
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
                restaurant.Tables.Add(table);
                tableNumberTextBox.Text = (int.Parse(tableNumberTextBox.Text)+1).ToString();
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
            metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

    }
}
