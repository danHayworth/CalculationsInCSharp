using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class TenNumbers
    {
        static void Main(string[] args)
        {
            int[] answer = new int[10];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("The sum is " + answer.Sum());
            Console.WriteLine("The average is " + answer.Average());
           
           
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
