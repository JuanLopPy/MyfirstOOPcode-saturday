using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public abstract class Employee
    {
        #region properties
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDay{ get; set; }
        public Date HiringDate { get; set; }
        public bool Isactive { get; set; }

        #endregion
        #region methods
        public abstract decimal GetValueToPay();
        public override string ToString() {

            return $"---------------EMPLOYEE------------\n\t " +
            $"ID:............... {Id} \n\t " +
            $"First Name:....... {FirstName}\n\t " +
            $"Last Name:........ {LastName}\n\t " +
            $"BirthDay: .........{BirthDay}\n\t " +
            $"Hiring Date:.......{HiringDate}\n\t " +
            $"is active:.........{Isactive}"; 
        }

        #endregion







    }
}
