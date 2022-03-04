using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class LargestNumber
    {
        public static void FindLargestNumber()
        {
            int a,b,c;
            Console.WriteLine("Enter 1st no");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd no");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd no");
            c = Convert.ToInt32(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine("The largest no :" + a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("The largest no :" + b);
            }
            else
            {
                Console.WriteLine("The largest no:" + c);
            }
        }
    }
}
