using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class HourlyEmployee :Employee
    {
        #region properties
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

       

        #endregion

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {

            return $"{base.ToString()}\n\t" +
                $"Hours: {Hours:N2}\n\t" +
                $"Value....................{HourValue:N2}\n\t" +
                $"Value to pay...................{GetValueToPay():c2}";
        }

        #region methods






        #endregion




    }
}
