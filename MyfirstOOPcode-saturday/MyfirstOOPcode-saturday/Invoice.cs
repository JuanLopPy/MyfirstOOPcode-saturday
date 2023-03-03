using MyfirstOOPcode_saturday.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class Invoice : IPay
    {
        #region properties
        public String Id { get; set; }
        public String Description { get; set; }
        public float Quiantity { get; set; }
        public decimal price { get; set; }


        #endregion
        public decimal GetValueToPay()
        {
            return price * (decimal)Quiantity;
        }

        public override string ToString()
        {
            return $"Id={Id} - Description={Description}\n\t" +
                $"Quantity........{Quiantity}\n\t" +
                $"price...........{price:C2}\n\t" +
                $"Invoice value...{GetValueToPay():C2}";


        }
    }
}
