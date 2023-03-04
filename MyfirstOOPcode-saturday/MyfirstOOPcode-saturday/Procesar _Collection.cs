using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class Procesar__Collection
    {

        #region methods

        public decimal ProcesarColeccion(ICollection<Employee> Employee)
        {
            decimal Payroll = 0;
            foreach (Employee employee in Employee)
            {
                if (employee.Isactive == true)
                {
                    Console.WriteLine(employee);

                    Payroll = Payroll + employee.GetValueToPay();
                }


            }
            return Payroll;



            #endregion

        }
    }
}
