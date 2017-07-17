using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class FoodItem
    {

        #region Properties

        public long? Id
        {
            get;set;
        }
        public string FoodName
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public int Grams
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public string Category
        {
            get; set;
        }

        #endregion

        #region Constructors

        public FoodItem() { }
        public FoodItem(long id,string foodname, double price, int grams, string category, string description)
        {
            this.Id = id;
            this.FoodName = foodname;
            this.Price = price;
            this.Grams = grams;
            this.Category = category;
            this.Description = description;
        }
        #endregion
    }
}
