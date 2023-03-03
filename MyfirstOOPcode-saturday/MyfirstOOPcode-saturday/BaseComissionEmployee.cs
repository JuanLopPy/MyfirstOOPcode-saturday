using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class BaseComissionEmployee: CommisionEmployee
    {
        #region propierties
        public decimal Base { get; set; }
        #endregion
        #region methods
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay()+Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Salario Base:...............{Base:c2}\n\t" +
                $"Salario Total:.......{GetValueToPay():c2}";
        }
        #endregion


    }
}
