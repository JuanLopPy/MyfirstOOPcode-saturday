using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class SalaryEmployee : Employee
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
            return $"Su salario es: {GetValueToPay()}";

        }

        #region Methods


        #endregion
    }
}
