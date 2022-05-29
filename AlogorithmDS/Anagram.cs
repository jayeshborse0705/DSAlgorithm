using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogorithmDS
{
    internal class Anagram
    {
        public void Anagrams1()
        {
            Console.WriteLine("Enter the String first:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the String second:");
            string Sstr2 = Console.ReadLine();

            char[] charFirst = str1.ToCharArray();
            char[] charSecond = Sstr2.ToCharArray();
            Array.Sort(charFirst);
            Array.Sort(charSecond);

            string string1 = new string(charFirst);
            string string2 = new string(charSecond);
            if (string1 == string2)
            {
                Console.WriteLine("The Entered Words are Anagrams", string1, string2);
            }
            else
            {
                Console.WriteLine("The Entered Words are not Anagrams", string1, string2);
            }
        }
    }
}
