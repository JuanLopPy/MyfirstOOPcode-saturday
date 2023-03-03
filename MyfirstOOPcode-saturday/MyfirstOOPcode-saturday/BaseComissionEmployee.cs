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
                $"Base:...............{Base:c2}\n\t" +
                $"Total value to pay:.......{GetValueToPay():c2}";
        }
        #endregion


    }
}
