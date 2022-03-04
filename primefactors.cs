using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
     class primefactors
    {
        public static void computeprimefactors()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("enter the number to find prime factors");
            int n= Convert.ToInt32(Console.ReadLine());
            int i,j;
            int count = 0;
            int flag = 0;
            int factor;
            for (i = 1; i < (n/2);i++)
            {
                if(n%i== 0)
                {
                    factor = i;
                    
                    for (j=2;j<=(factor/2);)
                    {
                        if(factor%j == 0)
                        {
                            flag = 1;
                            break;
                        }
                        j = j + 1;
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("prime factors are " + i);
                    }
                    count = 1;
                }
                i = i + 1;

            }
            if (count == 0) 
            {
                Console.WriteLine("no prime factors found");
            }
        }
    }
}
