using Entities;
using MetroFramework.Forms;
using Restaurant_Manager_Windows_Application.Forms;
using System;
using System.Data.SQLite;
using System.IO;

namespace Restaurant_Manager_Windows_Application
{
    public partial class MainForm : MetroForm
    {

        private static Restaurant restaurant = new Restaurant();
        private static SQLiteConnection connection = new SQLiteConnection("Data Source=database.db");

        public static Restaurant Restaurant
        {
            get
            {
                return restaurant;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        #region Tiles Click Event

        //Events that hides the main form
        //and display another form

        private void reservationsTile_Click(object sender, EventArgs e)
        {
            ReservationsForm rf = new ReservationsForm(this);
            this.Hide();
            rf.Show();
        }

        private void employeesTile_Click(object sender, EventArgs e)
        {
            EmployeesForm ef = new EmployeesForm(this);
            ef.Show();
            this.Hide();
        }

        private void menuTile_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm(this);
            mf.Show();
            this.Hide();
        }

        private void tablesTile_Click(object sender, EventArgs e)
        {
            TablesForm tf = new TablesForm(this);
            tf.Show();
            this.Hide();
        }

        private void statisticsTile_Click(object sender, EventArgs e)
        {
            StatisticsForm st = new StatisticsForm(this);
            st.Show();
            this.Hide();
        }

        private void receiptTile_Click(object sender, EventArgs e)
        {
            ReceiptForm rf = new ReceiptForm(this);
            rf.Show();
            this.Hide();
        }

        #endregion

        #region Tiles Hover Color Change Event

        //Mouse enter and leave events that changes the color of the tile from Default To Teal

        private void ReservationsTile_MouseEnter(object sender, EventArgs e)
        {
            ReservationsTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void ReservationsTile_MouseLeave(object sender, EventArgs e)
        {
            ReservationsTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void tablesTile_MouseEnter(object sender, EventArgs e)
        {
            tablesTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void tablesTile_MouseLeave(object sender, EventArgs e)
        {
            tablesTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void employeesTile_MouseEnter(object sender, EventArgs e)
        {
            employeesTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void employeesTile_MouseLeave(object sender, EventArgs e)
        {
            employeesTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void menuTile_MouseEnter(object sender, EventArgs e)
        {
            menuTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void menuTile_MouseLeave(object sender, EventArgs e)
        {
            menuTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void statisticsTile_MouseEnter(object sender, EventArgs e)
        {
            statisticsTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void statisticsTile_MouseLeave(object sender, EventArgs e)
        {
            statisticsTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void receiptTile_MouseEnter(object sender, EventArgs e)
        {
            receiptTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void receiptTile_MouseLeave(object sender, EventArgs e)
        {
            receiptTile.Style = MetroFramework.MetroColorStyle.Default;
        }


        #endregion

        #region Form Load Event

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("database.db"))
            {
                readDatabase(connection);
            }
            else
            {
                createDatabase(connection);
            }
        }
        
        #endregion Form Load Event

        #endregion Events

        #region Functions

        void readDatabase(SQLiteConnection connection)
        {
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

        void createDatabase(SQLiteConnection connection)
        {
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

        #endregion Functions

    }
}
