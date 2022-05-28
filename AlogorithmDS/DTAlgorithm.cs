using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogorithmDS
{
    internal class DTAlgorithm
    {
        public void Insert()
        {
            string[] names = { "Rat", "Zebra", "Bull", "Monkey" };
            InsertSort(names);
            foreach (var list in names)
            {
                Console.WriteLine(list);
            }
        }
        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {

                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}
