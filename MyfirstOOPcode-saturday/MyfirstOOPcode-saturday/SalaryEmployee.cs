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
            return $"{base.ToString()}\n\t"+
                $"Su salario es: {GetValueToPay()}c2";

        } 

        #region Methods


        #endregion
    }
}
