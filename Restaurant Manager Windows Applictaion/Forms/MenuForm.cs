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
        private FoodItem foodItemToEdit = null;
        public MenuForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
        }

        #region Close form event
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (foodItemToEdit != null)
            {
                restaurant.Menu.Add(foodItemToEdit);
            }
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
                resetFields(); 
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

        private void resetFields()
        {
            foodNameTextBox.Text = "";
            categoryTextBox.Text = "";
            gramsTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
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
                    item.Grams = grams;
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
                item.Id = foodItemToEdit.Id;
                foodItemToEdit = item;
                restaurant.Menu.Add(foodItemToEdit);

                SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE FoodItems SET FoodName ='" + foodItemToEdit.FoodName + "' , Price = " + foodItemToEdit.Price + " , Grams = " + foodItemToEdit.Grams + " , Description = '" + foodItemToEdit.Description + "' , Category = '" + foodItemToEdit.Category + "' WHERE Id=" + foodItemToEdit.Id, connection);
                cmd.ExecuteNonQuery();
                resetFields();
                bindToDataGrid();
                MetroMessageBox.Show(this, "\nMenu item was edited succesfully!", "Menu Item Edited", MessageBoxButtons.OK, MessageBoxIcon.None);
                addFoodItemButton.Visible = true;
                metroTabPage1.Text = "Add New Menu Item";
                foodItemToEdit = null;
                metroTabControl1.SelectedIndex = 1;

            }
            else
            {
                MetroMessageBox.Show(this, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //If i have fooditems i get the one selected and delete it from database and datastructure
            if (restaurant.Menu.Count == 0)
            {
                MetroMessageBox.Show(this, "\nThere are no food items to delete!", "Deleting Food Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "\nAre you sure you want to delete this food item?", "Deleting Food Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
                    connection.Open();

                    SQLiteCommand cmd = new SQLiteCommand("DELETE FROM FoodItems WHERE Id=" + metroGrid2.SelectedRows[0].Cells["Id"].Value, connection);
                    cmd.ExecuteNonQuery();
                    foreach (FoodItem fi in restaurant.Menu)
                    {
                        if (fi.Id == (long)metroGrid2.SelectedRows[0].Cells["Id"].Value)
                        {
                            restaurant.Menu.Remove(fi);
                            break;
                        }
                    }
                    bindToDataGrid();
                    connection.Close();
                }
            }
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            if (restaurant.Employee.Count == 0)
            {
                MetroMessageBox.Show(this, "\nThere is no food item selected to edit!", "No food item", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //get the employee selected
                foodItemToEdit = new FoodItem();
                foreach (FoodItem fi in restaurant.Menu)
                {
                    if (fi.Id == ((long)metroGrid2.SelectedRows[0].Cells["Id"].Value))
                    {
                        foodItemToEdit = fi;
                        restaurant.Menu.Remove(fi);
                        break;
                    }
                }

                //change tab
                metroTabControl1.SelectedIndex = 0;
                metroTabPage1.Text = "Edit Menu Item";

                //fill fields with employee's data 
                foodNameTextBox.Text = foodItemToEdit.FoodName;
                categoryTextBox.Text = foodItemToEdit.Category;
                gramsTextBox.Text = foodItemToEdit.Grams.ToString();
                priceTextBox.Text = foodItemToEdit.Price.ToString();
                descriptionTextBox.Text = foodItemToEdit.Description;

                //display the edit button
                addFoodItemButton.Visible = false;
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindToDataGrid();
            if (foodItemToEdit != null && metroTabControl1.SelectedIndex == 1)
            {
                metroTabControl1.SelectedIndex = 0;
                MetroMessageBox.Show(this, "\nPlease edit the menu item before changing the tab!", "Menu item edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
