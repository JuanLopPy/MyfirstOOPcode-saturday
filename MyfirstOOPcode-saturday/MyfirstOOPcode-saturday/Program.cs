﻿using System;
using System.Collections.Generic;

namespace MyfirstOOPcode_saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Read = new Read_date();

              //  Date dateobject = new Date(Read.ReadDay(), Read.ReadMonth(), Read.ReadYear());
              //Date dateobject2 = new Date(Read.ReadDayContrat(), Read.ReadMonthContrat(), Read.ReadYearContrat());

                SalaryEmployee SalaryEmployeeobjct = new SalaryEmployee()
                {
                    Id = Read.ID(),
                    FirstName = Read.ReadName(),
                    LastName = Read.ReadLastName(),
                    Salary = Read.ReadSalary(),
                   // BirthDay = (dateobject),
                    //HiringDate = (dateobject2),
                    Isactive = Read.IsActive(),


                };
                Console.WriteLine("Empleado por comisión");


                CommisionEmployee CommisionEmployee = new CommisionEmployee()

                {
                    Id = Read.ID(),
                    FirstName = Read.ReadName(),
                    LastName = Read.ReadLastName(),
                   // BirthDay = (dateobject),
                   //HiringDate = (dateobject2),
                    Isactive = Read.IsActive(),
                    comissionPorcenteje = Read.ComisionPorcentage(),
                    sales = Read.ReadSalary(),


                };
                Console.WriteLine("Empleado por hora");

                HourlyEmployee HourlyEmployee = new HourlyEmployee()
                {
                    Id = Read.ID(),
                    FirstName = Read.ReadName(),
                    LastName = Read.ReadLastName(),
                    //BirthDay = (dateobject),
                   // HiringDate = (dateobject2),
                    Isactive = Read.IsActive(),
                    Hours = Read.ReadHours(),
                    HourValue = Read.ValueHours(),


                };
                Console.WriteLine("Empleado por comisión + base");


                BaseComissionEmployee baseCommisionEmployee = new BaseComissionEmployee()
                {
                    Id = Read.ID(),
                    FirstName = Read.ReadName(),
                    LastName = Read.ReadLastName(),
                   // BirthDay = (dateobject),
                   // HiringDate = (dateobject2),
                    Isactive = Read.IsActive(),
                    comissionPorcenteje = Read.ComisionPorcentage(),
                    sales = Read.ReadSalary(),
                    Base = Read.BaseSalary(),

                };
                //Console.WriteLine(baseCommisionEmployee.ToString());
                
                //List<String> names = new List<string>();

                ICollection<Employee> employees = new List<Employee>() {
                SalaryEmployeeobjct,
                CommisionEmployee,
                HourlyEmployee,
                baseCommisionEmployee

                };
               
                Procesar__Collection procesar= new Procesar__Collection();
              
                decimal payrol= procesar.ProcesarColeccion(employees);

               /* foreach (Employee employee in employees)
                {
                    if (employee.Isactive == true) {
                        Console.WriteLine(employee);
                        names.Add(employee.FirstName);
                        Payroll = Payroll + employee.GetValueToPay();
                        Console.WriteLine("");
                    }*/


                
                Console.WriteLine("su nomina total es: " + payrol );

              /*  foreach (String name in names)
                {

                    Console.WriteLine(name);
                    Console.WriteLine("");

                }*/

                Console.WriteLine("INVOICE");

                Invoice invoice = new Invoice()
                {
                    Id = Read.ID(),
                    Description=Read.Description(),
                    price=Read.Price(),
                    Quiantity=Read.Quantity(),  

                };





                 }





            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }

           
        }
    }
}
