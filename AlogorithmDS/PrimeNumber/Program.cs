using System;
public class Program
{
    public static void Main()
    {
        int num, i, ctr, firstNum, endno;

        
        Console.WriteLine("Find the prime numbers within a range of numbers:");
       Console.WriteLine("Input starting number of range: ");
        firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input ending number of range : ");
        endno = Convert.ToInt32(Console.ReadLine());
        Console.Write("The prime numbers between {0} and {1} are : \n", firstNum, endno);

        for (num = firstNum; num<=endno; num++)
        {
            ctr = 0;

            for (i=2; i<=num/2; i++)
            {
                if (num%i==0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr==0 && num!= 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}
