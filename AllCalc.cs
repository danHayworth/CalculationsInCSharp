using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class AllCalc
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter the first number:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            Console.WriteLine("{0} % {1} = {2}", num1, num2, (num1 % num2));
            Console.ReadLine();
        }
    }
}
