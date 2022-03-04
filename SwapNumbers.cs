using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class SwapNumbers
    {
        public static void SwaptwoNumbers()
        {
            int a, b;
            Console.WriteLine("Enter the number for variable a");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number for variable b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping numbers are a="+a +"b=" +b);

            a = a * b;  //swapping of numbers
            b= a / b;
            a = a / b;

            Console.WriteLine("After swapping numbers are a=" + a + "b=" + b);
        }
    }
}
