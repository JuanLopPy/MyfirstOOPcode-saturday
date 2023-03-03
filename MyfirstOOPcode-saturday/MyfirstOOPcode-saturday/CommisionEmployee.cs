using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class CommisionEmployee:Employee
    {
        #region propierties
        public decimal sales { get; set; }
        public double comissionPorcenteje { get; set; }
        public double comissionConvert { get; set; }
        #endregion propiertes
        #region methods
        public override decimal GetValueToPay()
        {
            return ((decimal)comissionPorcenteje/100)*sales;
        }


        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                 $"Ingresa tu comisíon en porcentaje:.... {comissionPorcenteje}%\n\t" +
                 $"ventas:....................{sales:c2}\n\t" +
                 $"Total salario:.............{GetValueToPay():c2}";

        }
   


        #endregion






    }
}
