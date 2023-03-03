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
        public string ReadName() {

            Console.WriteLine("Ingrese su nombre:");
            string name = Console.ReadLine();
            return name;
        }
        public string ReadLastName()
        {

            Console.WriteLine("Ingrese su apellido:");
            string name = Console.ReadLine();
            return name;
        }
        public int ReadDayContrat()
        {

            Console.WriteLine("Ingrese el día de contratación: ");
            string input = Console.ReadLine();
            int day = int.Parse(input);
            return day;


        }
        public int ReadMonthContrat()
        {
            Console.WriteLine("Ingrese el Mes de contrataciónn: ");
            string input = Console.ReadLine();
            int Month = int.Parse(input);
            return Month;
        }
        public double ComisionPorcentage() 
        {

            Console.WriteLine("Ingresa tu comisión en porcentaje ");
            string input = Console.ReadLine();
            double Comision = double.Parse(input);
            return Comision;
        }
        public int ReadYearContrat()
        {

            Console.WriteLine("Ingrese el año de contratación: ");
            string input = Console.ReadLine();
            int year = int.Parse(input);
            return year;
        }
        public string ID()
        {

            Console.WriteLine("Ingrese su ID: ");
            string ID = Console.ReadLine();
            return ID;
        }
        public bool IsActive()
        {

            Console.WriteLine("Ingrese si es activo o no.");
            string active = Console.ReadLine();
            if (active!="si")
            {
                return false;
            }

            return true;
        }
        public float ReadHours()
        {

            Console.WriteLine("Type your number of hours:  ");
            string input = Console.ReadLine();
            float hours = float.Parse(input);
            return hours;

        }
        public decimal ValueHours()
        {

            Console.WriteLine("Type your value per hour:  ");
            string input = Console.ReadLine();
            decimal hours = decimal.Parse(input);
            return hours;

        }



        #endregion
    }
} 