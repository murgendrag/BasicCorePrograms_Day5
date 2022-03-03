using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class flipcoin
    {
        public static void headtailpercentage()
        {
            Console.WriteLine("Enter the no of times to flip the coin");
            int flip = Convert.ToInt32(Console.ReadLine());

            if (flip > 0) ;
            {
                int head = 1;
                int tail = 1;
                int headcount = 0;
                int tailcount = 0;
                double headpercentage;
                double tailpercentage;

                for (int i = 1; i <= flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount += tail;
                    }

                    else
                    {
                        headcount += head;
                    }

                }
                tailpercentage = (tailcount * 100) / flip;
                headpercentage = (headcount * 100) / flip;

                Console.WriteLine("headpercentage=" + headpercentage);
                Console.WriteLine("tailpercentage=" + tailpercentage);
            }
        }
    }
}
