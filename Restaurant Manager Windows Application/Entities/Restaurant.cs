using System;
using System.Collections.Generic;

namespace Entities
{
    [Serializable]
    public class Restaurant
    {
        #region Properties
        public List<Employee> Employee
        {
            get; set;
        }

        public List<Tables> Tables
        {
            get; set;
        }

        public List<Reservation> Reservations
        {
            get; set;
        }

        public List<FoodItem> Menu
        {
            get; set;
        }
        #endregion


        public Restaurant()
        {
            this.Employee = new List<Employee>();
            this.Tables = new List<Tables>();
            this.Reservations = new List<Reservation>();
            this.Menu = new List<FoodItem>();
        }
    }
}
