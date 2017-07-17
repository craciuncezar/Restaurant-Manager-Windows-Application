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

        public long? Id
        { get; set; }

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

        public long PhoneNumber
        { get; set; }

        #endregion

        #region Constructors
        public Reservation() { }
        public Reservation(long id,string resname, string datares, int nopers, int tableno, long phonenumber, string email)
        {
            this.Id = id;
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
