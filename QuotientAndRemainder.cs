using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class QuotientAndRemainder
    {
        public static void ComputeQuotientRemainder()
        {
            int Dividend,Divisor,Quotient,Remainder;
            Console.WriteLine("Enter dividend");
            Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor(not zero)");
            Divisor = Convert.ToInt32(Console.ReadLine());

            Quotient = Dividend / Divisor;
            Remainder=Dividend % Divisor;

            Console.WriteLine("Quotient:{0} Remainder:{1}" ,Quotient ,Remainder);


        }
    }
}
