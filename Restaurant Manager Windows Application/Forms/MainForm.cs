using Entities;
using MetroFramework.Forms;
using Restaurant_Manager_Windows_Application.Forms;
using System;

namespace Restaurant_Manager_Windows_Application
{
    public partial class MainForm : MetroForm
    {
        private static Restaurant restaurant = new Restaurant();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ReservationsForm rf = new ReservationsForm(this);
            rf.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            EmployeesForm ef = new EmployeesForm(this);
            ef.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm(this);
            mf.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            TablesForm tf = new TablesForm(this);
            tf.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            StatisticsForm st = new StatisticsForm(this);
            st.Show();
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ReceiptForm rf = new ReceiptForm(this);
            rf.Show();
            this.Hide();
        }
    }
}
