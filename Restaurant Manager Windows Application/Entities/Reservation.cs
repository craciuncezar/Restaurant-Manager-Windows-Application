using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Reservation
    {

        #region Properties
        public string Name
        { get; set; }

        public string Date
        { get; set; }

        public int NoPers
        { get; set; }

        public int TableNo
        { get; set; }

        public string Email
        { get; set; }

        public int PhoneNumber
        { get; set; }



        #endregion

        #region Constructors
        public Reservation() { }
        public Reservation(string resname, string datares, int nopers, int tableno, int phonenumber, string email)
        {
            this.Name = resname;
            this.Date = datares;
            this.NoPers = nopers;
            this.TableNo = tableno;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        #endregion
    }
}
