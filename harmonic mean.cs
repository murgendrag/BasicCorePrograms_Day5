using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
     class harmonic_mean
    {
        public static void calculateHM()
        {
            Console.WriteLine("program to calculate harmonic series and mean upto nth term");
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            double s = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/" + i);
               s+=1/(float)i;
            }   
            
            Console.WriteLine("harmonic mean upto "  + n +"  "  + s);
        }
    }
}
