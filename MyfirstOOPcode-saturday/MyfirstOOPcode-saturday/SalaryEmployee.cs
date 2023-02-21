using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    internal class SalaryEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"Value to pay: {GetValueToPay()}";

        }

        #region Methods


        #endregion
    }
}
