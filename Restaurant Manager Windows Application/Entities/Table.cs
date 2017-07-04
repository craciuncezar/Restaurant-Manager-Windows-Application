using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Tables
    {

        #region Properties
        public int Number
        {get;set;}

        public int MaxSeats
        {get; set;}
        #endregion

        #region Constructors
        public Tables()
        {}
        public Tables(int n, int m)
        {
            this.MaxSeats = m;
            this.Number = n;
        }
        #endregion

    }
}
