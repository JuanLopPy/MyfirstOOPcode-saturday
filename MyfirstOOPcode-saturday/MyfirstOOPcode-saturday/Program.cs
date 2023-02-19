using System;

namespace MyfirstOOPcode_saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try {
                var Read = new Read_date();
                var dateobject = new Date(Read.ReadDay(), Read.ReadMonth(), Read.ReadYear());
                Console.WriteLine(dateobject.ToString());
            } catch(Exception ex) {

                Console.WriteLine(ex.Message);
            }

           
        }
    }
}
