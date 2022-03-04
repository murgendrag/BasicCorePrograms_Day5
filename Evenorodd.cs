using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class Evenorodd
    {
        public static void CheckEvenorOdd()
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());

            if(number%2==0)
            {
                Console.WriteLine("The Number "+number +"is even number");
            }
            else
            {
                Console.WriteLine("The Number " + number + "is odd number");
            }
        }
    }
}
