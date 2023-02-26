using System;

namespace MyfirstOOPcode_saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try {
                var Read = new Read_date();
              
                SalaryEmployee SalaryEmployeeobjct = new SalaryEmployee();
                SalaryEmployeeobjct.Id = Read.ID();
                SalaryEmployeeobjct.FirstName = Read.ReadName();
                SalaryEmployeeobjct.LastName = Read.ReadLastName();
                var dateobject = new Date(Read.ReadDay(), Read.ReadMonth(), Read.ReadYear());
                var dateobject2 = new Date(Read.ReadDayContrat(), Read.ReadMonthContrat(), Read.ReadYearContrat());
                SalaryEmployeeobjct.Salary=Read.ReadSalary();
                SalaryEmployeeobjct.BirthDay = (dateobject);
                SalaryEmployeeobjct.HiringDate = (dateobject2);
                SalaryEmployeeobjct.Isactive = Read.IsActive();
                Console.WriteLine(SalaryEmployeeobjct.ToString());
                 






            } catch(Exception ex) {

                Console.WriteLine(ex.Message);
            }

           
        }
    }
}
