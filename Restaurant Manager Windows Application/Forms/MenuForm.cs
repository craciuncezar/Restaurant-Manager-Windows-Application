using Entities;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application.Forms
{
    public partial class MenuForm : MetroForm
    {
        private new MainForm Owner;
        private Restaurant restaurant = MainForm.Restaurant;
        public MenuForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
        }

        #region Close form event
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
        #endregion


        #region Load form event
        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            bindToDataGrid();
        }
        #endregion




        void bindToDataGrid()
        {
            var list = new BindingList<FoodItem>(restaurant.Menu);
            metroGrid2.DataSource = list;
            metroGrid2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void metroButton2_Click(object sender, System.EventArgs e)
        {
            FoodItem item = new FoodItem();
            bool valid = true;


            if (string.IsNullOrWhiteSpace(foodNameTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider1.SetError(foodNameTextBox, "Food name cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(foodNameTextBox, null);
                item.FoodName = foodNameTextBox.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(categoryTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider2.SetError(categoryTextBox, "Category cannot be empty!");
            }
            else
            {
                errorProvider2.SetError(categoryTextBox, null);
                item.Category = categoryTextBox.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(gramsTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider3.SetError(gramsTextBox, "Grams cannot be empty!\n");
            }
            else
            {
                try
                {
                    errorProvider3.SetError(gramsTextBox, null);
                    int grams = Convert.ToInt32(gramsTextBox.Text);
                    if (grams < 0)
                    {
                        valid = false;
                        errorProvider3.SetError(gramsTextBox, "The number must be positive!");
                    }
                    item.Grams= grams;
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider3.SetError(gramsTextBox, "Invalid number!");
                }
            }

            if (string.IsNullOrWhiteSpace(priceTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider4.SetError(priceTextBox, "Price cannot be empty!\n");
            }
            else
            {
                try
                {
                    errorProvider4.SetError(priceTextBox, null);
                    int price = Convert.ToInt32(priceTextBox.Text);
                    if (price < 0)
                    {
                        valid = false;
                        errorProvider4.SetError(priceTextBox, "The price must be positive!");
                    }
                    item.Price = price;
                }
                catch (Exception)
                {
                    valid = false;
                    errorProvider4.SetError(priceTextBox, "Invalid number!");
                }
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider5.SetError(descriptionTextBox, "Description cannot be empty!");
            }
            else
            {
                errorProvider5.SetError(descriptionTextBox, null);
                item.Description = descriptionTextBox.Text.Trim();
            }

            if (valid)
            {
                addFoodItem(item);
                bindToDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addFoodItem(FoodItem fooditem)
        {
            var queryString = "insert into FoodItems(FoodName, Price, Grams, Description, Category)" +
                              " values(@FoodName,@Price,@Grams,@Description,@Category);  " +
                              "SELECT last_insert_rowid()";

            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();

            var command = new SQLiteCommand(queryString, connection);
            var nameParameter = new SQLiteParameter("@FoodName");
            nameParameter.Value = fooditem.FoodName;
            var priceParameter = new SQLiteParameter("@Price");
            priceParameter.Value = fooditem.Price;
            var gramsParameter = new SQLiteParameter("@Grams");
            gramsParameter.Value = fooditem.Grams;
            var descriptionParameter = new SQLiteParameter("@Description");
            descriptionParameter.Value = fooditem.Description;
            var categoryParameter = new SQLiteParameter("@Category");
            categoryParameter.Value = fooditem.Category;

            command.Parameters.Add(nameParameter);
            command.Parameters.Add(priceParameter);
            command.Parameters.Add(gramsParameter);
            command.Parameters.Add(descriptionParameter);
            command.Parameters.Add(categoryParameter);

            fooditem.Id = (long)command.ExecuteScalar();

            restaurant.Menu.Add(fooditem);

            connection.Close();

        }
    }
}
