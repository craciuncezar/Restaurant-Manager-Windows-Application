using Entities;
using MetroFramework.Forms;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application
{
    public partial class MainForm : MetroForm
    {

        private static Restaurant restaurant = new Restaurant();
        private Panel currentBtn;

        public static Restaurant Restaurant
        {
            get
            {
                return restaurant;
            }
        }

        public MainForm()
        {
            if (File.Exists("database.db"))
            {
                readDatabase();
            }
            else
            {
                createDatabase();
            }
            InitializeComponent();
        }

        #region Events

        #region Form Load Event

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentBtn = reservationsBtn;
        }

        #endregion Form Load Event

        #endregion Events

        #region DatabaseFunctions

        void readDatabase()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");

            connection.Open();

            #region Employees
            string stringSql = "SELECT * FROM Employees";

            var command = new SQLiteCommand(stringSql, connection);

            SQLiteDataReader sqlReader = command.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    restaurant.Employee.Add(new Employee((long)sqlReader["Id"], (string)sqlReader["FirstName"],(string)sqlReader["LastName"],(int)sqlReader["Wage"],(string)sqlReader["Gender"],(string)sqlReader["Position"],(string)sqlReader["Birthdate"]));
                }
            }
            finally
            {
                sqlReader.Close();
            }
            #endregion

            #region Reservations
            stringSql = "SELECT * FROM Reservations";

            command = new SQLiteCommand(stringSql, connection);

            sqlReader = command.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    restaurant.Reservations.Add(new Reservation((long)sqlReader["Id"], (String)sqlReader["Name"], (String)sqlReader["Date"], (Int32)sqlReader["NoPers"], (Int32)sqlReader["TableNo"], (Int32)sqlReader["PhoneNumber"], (String)sqlReader["Email"]));
                }
            }
            finally
            {
                sqlReader.Close();
            }
            #endregion

            #region Tables
            stringSql = "SELECT * FROM Tables";

            command = new SQLiteCommand(stringSql, connection);

            sqlReader = command.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    restaurant.Tables.Add(new Tables((long)sqlReader["Id"], (int)sqlReader["Number"], (int)sqlReader["MaxSeats"]));
                }
            }
            finally
            {
                sqlReader.Close();
            }
            #endregion

            #region FoodItems
            stringSql = "SELECT * FROM FoodItems";

            command = new SQLiteCommand(stringSql, connection);

            sqlReader = command.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    restaurant.Menu.Add(new FoodItem((long)sqlReader["Id"], (string)sqlReader["FoodName"], (double)sqlReader["Price"], (int)sqlReader["Grams"], (string)sqlReader["Description"], (string)sqlReader["Category"]));
                }
            }
            finally
            {
                sqlReader.Close();
            }
            #endregion

            connection.Close();
        }

        void createDatabase()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");

            try
            {
                SQLiteConnection.CreateFile("database.db");

                connection.Open();

                string sql = "create table Employees (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, FirstName TEXT, LastName TEXT, Wage INT, Position TEXT, Birthdate TEXT, Gender TEXT);"
                    + "CREATE TABLE Reservations (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT, Date TEXT, NoPers INT, TableNo INT, Email TEXT, PhoneNumber INT);"
                    + "CREATE TABLE Tables (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Number INT, MaxSeats INT);"
                    + "CREATE TABLE FoodItems (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, FoodName TEXT, Price REAL, Grams INT, Description TEXT, Category TEXT);";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion DatabaseFunctions

        #region Buttons mouse hover color change 
        #endregion


        private void menuButtons_MouseEnter(object sender, EventArgs e)
        {
            //Control panel = sender as Control;
            //panel.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
        }

        private void menuButtons_MouseLeave(object sender, EventArgs e)
        {
            //Control panel = sender as Control;
            //panel.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
        }

        private void displayReservationsClick(object sender, EventArgs e)
        {
            reservationsUserControl1.Visible = true;
            receiptUserControl1.Visible = false;
            employeesUserControl1.Visible = false;
            restaurantMenuUserControl1.Visible = false;
            tablesUserControl1.Visible = false;
            barChartUserControl1.Visible = false;

            currentBtn.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
            reservationsBtn.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
            currentBtn = reservationsBtn;
        }

        private void receiptBtnClick(object sender, EventArgs e)
        {
            reservationsUserControl1.Visible = false;
            receiptUserControl1.Visible = true;
            employeesUserControl1.Visible = false;
            restaurantMenuUserControl1.Visible = false;
            tablesUserControl1.Visible = false;
            barChartUserControl1.Visible = false;

            currentBtn.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
            receiptBtn.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
            currentBtn = receiptBtn;
        }

        private void employeesBtnClick(object sender, EventArgs e)
        {
            reservationsUserControl1.Visible = false;
            receiptUserControl1.Visible = false;
            employeesUserControl1.Visible = true;
            tablesUserControl1.Visible = false;
            restaurantMenuUserControl1.Visible = false;
            barChartUserControl1.Visible = false;

            currentBtn.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
            employeesBtn.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
            currentBtn = employeesBtn;
        }

        private void tablesBtnClick(object sender, EventArgs e)
        {
            reservationsUserControl1.Visible = false;
            receiptUserControl1.Visible = false;
            employeesUserControl1.Visible = false;
            tablesUserControl1.Visible = true;
            restaurantMenuUserControl1.Visible = false;
            barChartUserControl1.Visible = false;

            currentBtn.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
            tablesBtn.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
            currentBtn = tablesBtn;

        }

        private void menuBtnClick(object sender, EventArgs e)
        {
            reservationsUserControl1.Visible = false;
            receiptUserControl1.Visible = false;
            employeesUserControl1.Visible = false;
            tablesUserControl1.Visible = false;
            restaurantMenuUserControl1.Visible = true;
            barChartUserControl1.Visible = false;

            currentBtn.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
            menuBtn.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
            currentBtn = menuBtn;

        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            reservationsUserControl1.Visible = false;
            receiptUserControl1.Visible = false;
            employeesUserControl1.Visible = false;
            tablesUserControl1.Visible = false;
            restaurantMenuUserControl1.Visible = false;
            barChartUserControl1.Visible = true;

            currentBtn.BackColor = System.Drawing.Color.FromArgb(3, 155, 229);
            statisticsBtn.BackColor = System.Drawing.Color.FromArgb(59, 89, 152);
            currentBtn = statisticsBtn;

        }
    }
}
