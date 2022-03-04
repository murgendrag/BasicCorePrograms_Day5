using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class VowelsorConsonant
    {
        public static void CheckVowelorConsonant()
        {
            char alpha;
            Console.WriteLine("Enter alphabet to check Vowel or Consonant");
            alpha = Convert.ToChar(Console.ReadLine());    

            if (alpha=='a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u')
            {
                Console.WriteLine( alpha +" is Vowel");
            }
            else
            {
                Console.WriteLine(alpha + "This is Consonant");

            }
        }
    }
}
