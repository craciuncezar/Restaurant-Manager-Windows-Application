using System;
using System.ComponentModel;
using System.Windows.Forms;
using Restaurant_Manager_Windows_Application;
using Entities;
using MetroFramework;
using System.Data.SQLite;

namespace Restaurant_Manager_Windows_Applictaion.Forms
{
    public partial class RestaurantMenuUserControl : UserControl
    {

        private Restaurant restaurant = MainForm.Restaurant;
        private FoodItem foodItemToEdit = null;

        public RestaurantMenuUserControl()
        {
            InitializeComponent();
        }

        #region Events

        private void RestaurantMenuUserControl_Load(object sender, EventArgs e)
        {
            bindToDataGrid();
        }

        private void addFoodItemBtn_click(object sender, System.EventArgs e)
        {
            FoodItem item = new FoodItem();      

            if (formValidation(item))
            {
                addFoodItemToDB(item);
                resetFields();
                metroTabControl1.SelectedIndex = 0;
            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            FoodItem item = new FoodItem();

            if (formValidation(item))
            {
                item.Id = foodItemToEdit.Id;
                foodItemToEdit = null;

                restaurant.Menu.Add(item);
                updateFoodItemDB(item);

                resetFields();
                addFoodItemButton.Visible = true;
                cancelEditBtn.Visible = false;
                metroTabPage1.Text = "Add New Menu Item";
                MetroMessageBox.Show(MainForm.ActiveForm, "\nMenu item was edited succesfully!", "Menu Item Edited", MessageBoxButtons.OK, MessageBoxIcon.None);
                metroTabControl1.SelectedIndex = 0;                
            }
            else
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nData inserted is not valid, please check the warnings and try again!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (restaurant.Menu.Count == 0)
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nThere are no food items to delete!", "Deleting Food Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(MainForm.ActiveForm, "\nAre you sure you want to delete " + metroGrid2.SelectedRows[0].Cells[1].Value + "?", "Deleting Food Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteFoodItemDB();

                    foreach (FoodItem fi in restaurant.Menu)
                    { 
                        if (fi.Id == (long)metroGrid2.SelectedRows[0].Cells["Id"].Value)
                        {
                            restaurant.Menu.Remove(fi);
                            break;
                        }
                    }
                    bindToDataGrid();
                }
            }
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            if (restaurant.Menu.Count == 0)
            {
                MetroMessageBox.Show(MainForm.ActiveForm, "\nThere is no food item selected to edit!", "No food item", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                metroTabControl1.SelectedIndex = 1;
                metroTabPage1.Text = "Edit Menu Item";

                //fill fields with employee's data 
                foodNameTextBox.Text = foodItemToEdit.FoodName;
                categoryTextBox.Text = foodItemToEdit.Category;
                gramsTextBox.Text = foodItemToEdit.Grams.ToString();
                priceTextBox.Text = foodItemToEdit.Price.ToString();
                descriptionTextBox.Text = foodItemToEdit.Description;

                //display the edit buttons
                addFoodItemButton.Visible = false;
                cancelEditBtn.Visible = true;
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindToDataGrid();
            if (foodItemToEdit != null && metroTabControl1.SelectedIndex == 0)
            {
                metroTabControl1.SelectedIndex = 1;
                MetroMessageBox.Show(MainForm.ActiveForm, "\nPlease edit the menu item before changing the tab!", "Menu item edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelEditBtn_Click(object sender, EventArgs e)
        {
            restaurant.Menu.Add(foodItemToEdit);
            resetFields();
            addFoodItemButton.Visible = true;
            cancelEditBtn.Visible = false;
            metroTabPage1.Text = "Add New Menu Item";
            foodItemToEdit = null;
            metroTabControl1.SelectedIndex = 0;
        }

        #endregion

        #region Methods

        private void bindToDataGrid()
        {
            var list = new BindingList<FoodItem>(restaurant.Menu);
            metroGrid2.DataSource = list;
            metroGrid2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private bool formValidation(FoodItem newFoodItem)
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(foodNameTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider1.SetError(foodNameTextBox, "Food name cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(foodNameTextBox, null);
                newFoodItem.FoodName = foodNameTextBox.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(categoryTextBox.Text.Trim()))
            {
                valid = false;
                errorProvider2.SetError(categoryTextBox, "Category cannot be empty!");
            }
            else
            {
                errorProvider2.SetError(categoryTextBox, null);
                newFoodItem.Category = categoryTextBox.Text.Trim();
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
                    newFoodItem.Grams = grams;
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
                    Double price = Convert.ToDouble(priceTextBox.Text);
                    if (price < 0)
                    {
                        valid = false;
                        errorProvider4.SetError(priceTextBox, "The price must be positive!");
                    }
                    newFoodItem.Price = price;
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
                newFoodItem.Description = descriptionTextBox.Text.Trim();
            }

            return valid;
        } 

        private void resetFields()
        {
            foodNameTextBox.Text = "";
            categoryTextBox.Text = "";
            gramsTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void addFoodItemToDB(FoodItem fooditem)
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

        private void updateFoodItemDB(FoodItem foodItemToEdit)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE FoodItems SET FoodName ='" + foodItemToEdit.FoodName + "' , Price = " + foodItemToEdit.Price + " , Grams = " + foodItemToEdit.Grams + " , Description = '" + foodItemToEdit.Description + "' , Category = '" + foodItemToEdit.Category + "' WHERE Id=" + foodItemToEdit.Id, connection);
            cmd.ExecuteNonQuery();
        }

        private void deleteFoodItemDB()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM FoodItems WHERE Id=" + metroGrid2.SelectedRows[0].Cells["Id"].Value, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        #endregion

    }
}

