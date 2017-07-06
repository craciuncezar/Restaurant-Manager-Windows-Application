using Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager_Windows_Application.Forms
{
    public partial class StatisticsForm : MetroForm
    {
        private Restaurant restaurant = MainForm.Restaurant;
        private new MainForm Owner;
        public StatisticsForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
        }

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
        }
    }
}
