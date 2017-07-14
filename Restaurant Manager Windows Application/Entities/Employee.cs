using System;

namespace Entities
{
    [Serializable]
    public class Employee
    {

        #region Properties
        public long? Id
        {
            get;set;
        }
        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public int Wage
        {
            get; set;
        }

        public string Position
        {
            get; set;
        }

        public String Birthdate
        {
            get; set;
        }

        public string Gender
        {
            get; set;
        }
        #endregion

        #region Constructors
        public Employee() { }
        public Employee(long id,string firstName, string lastName, int wage, string gender,string position, String birthdate)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Wage = wage;
            this.Gender = gender;
            this.Position = position;
            this.Birthdate = birthdate;
        }
        #endregion
    }
}
