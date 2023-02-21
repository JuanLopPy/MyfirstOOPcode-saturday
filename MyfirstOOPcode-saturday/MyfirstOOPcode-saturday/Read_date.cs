using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class Read_date
    {
        #region Methods
        public Read_date()
        {

        }
        public int ReadDay()
        {
            
            Console.WriteLine("Ingrese el día de nacimiento: ");
            string input= Console.ReadLine();
            int day=int.Parse(input);
            return day;


        }
        public int ReadMonth()
        {
            Console.WriteLine("Ingrese el Mes de nacimiento: ");
            string input = Console.ReadLine();
            int Month=int.Parse(input);
            return Month;
        }
       
        public int ReadYear()
        {
            
            Console.WriteLine("Ingrese el año de nacimiento: ");
            string input = Console.ReadLine();
            int year = int.Parse(input);
            return year;
        }
        public decimal ReadSalary() {
            Console.WriteLine("Ingrese su salario: ");
            string input = Console.ReadLine();
            decimal salary = decimal.Parse(input);
            return salary;
        }

        #endregion
    }
} 