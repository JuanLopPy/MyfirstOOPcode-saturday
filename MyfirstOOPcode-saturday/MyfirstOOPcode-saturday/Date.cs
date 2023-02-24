using System;
using System.Collections.Generic;
using System.Text;

namespace MyfirstOOPcode_saturday
{
    public class Date
    {
        #region fields
        private int _day;
        private int _month;
        private int _year;
        #endregion
        #region Methods
        public Date(int day, int month, int year)
        {            
            _day=ValidateDay(day,month, year);
            _month=ValidateMonth(month);
            _year=ValidateYear(year);

        }

        private int ValidateDay(int day , int month, int year)
        {

            if (month == 2 && day == 29 && IspLepYear(year))
                {

                return day;
            }



            int[] daysperMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if( day >=1 && day <= daysperMonth[month]) {
                return day; 
            
            }


            throw new dayException();
        }


        private bool IspLepYear(int year) {
            bool Isleap=(year % 400 == 0 || year % 4==0 && year % 100!=0 );

            
            return Isleap;
        
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new yearException("Ingreso del año invalido ");
        }

        private int ValidateMonth(int month)
        {
            if (month >=1 && month<=12) {
                return month;
            
            }
            throw new monthException("Ingreso del mes invalido ");
        }

        public override string ToString()
        {
            string date = (""+_day +"/"+_month +"/" + _year);
            return date;    
             

        }




        #endregion}











    }
}
