using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Let's do multiplication table by a number you choose");
            a = Int32.Parse(Console.ReadLine());
            int[] b = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
            for (int j = 1; j <= 10; j++){
                Console.WriteLine("{0} * {1} = {2}", a, j, (a * j));
                }
            
            Console.ReadLine();
        }
    }
}
