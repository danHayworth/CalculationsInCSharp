using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class TwoIntegers
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            bool divi;

            Console.WriteLine("Let's just do some calculations, you will be asked to enter 2 numbers consecutively and if they both divisible by 2 or 3 u get their multiplication else their sum");
            Console.WriteLine("Enter the first number");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Int32.Parse(Console.ReadLine());
            calc();
            if(divi == true)
            {
                Console.WriteLine("Multiplicated " + (num1 * num2));
            }
            else
            {
                Console.WriteLine("Sum " + (num1 + num2));
            }

            void calc()
            {
                if (num1%2 == 0 || num1%3 == 0 && num2%2 == 0 || num2%3 == 0)
                {
                    divi = true;
                }
                else
                {
                    divi = false;
                }
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
