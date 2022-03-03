using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class class1
    {
        public static void checkleapyear()

        {
            Console.WriteLine("program to find whether year is leap year or not");
            Console.WriteLine("enter the year YYYY format");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year%4==0) && (year%100!=0) || (year % 400==0))
            {
                Console.WriteLine(year + "year is leap year");

            }
            else
            {
                Console.WriteLine(year + "year is not a leap year");
            }
        }
     }
}
