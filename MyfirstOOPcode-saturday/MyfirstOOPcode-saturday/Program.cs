using System;

namespace MyfirstOOPcode_saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try {
                var Read = new Read_date();
                Date dateobject = new Date(Read.ReadDay(), Read.ReadMonth(), Read.ReadYear());
                Date dateobject2 = new Date(Read.ReadDayContrat(), Read.ReadMonthContrat(), Read.ReadYearContrat());
                SalaryEmployee SalaryEmployeeobjct = new SalaryEmployee() {
                Id = Read.ID(),
                FirstName = Read.ReadName(),
                LastName = Read.ReadLastName(),
                Salary = Read.ReadSalary(),
                BirthDay = (dateobject),
                HiringDate = (dateobject2),
                Isactive = Read.IsActive(),

            };
               Console.WriteLine(SalaryEmployeeobjct.ToString());   
               
               
                 






            } catch(Exception ex) {

                Console.WriteLine(ex.Message);
            }

           
        }
    }
}
