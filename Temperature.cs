using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Temperature
    {
        static void TwoIntegers(string[] args)
        {
            double C = 0 ;
            double F = 0 ;
            
            Console.WriteLine("What would you like to transform into? \nC or F");
            string answer = Console.ReadLine();
            if(answer.ToUpper() == "C")
            {
                Console.WriteLine("What is the F temperature?");
                string faren = Console.ReadLine();
                F = Convert.ToDouble(faren);
                ftoc();
            }
            else if(answer.ToUpper() == "F")
            {
                Console.WriteLine("What is the C temperature?");
                string celsi = Console.ReadLine();
                C = Convert.ToDouble(celsi);
                ctof();
            }
            
            void ctof()
            {
                double output = (C * 9 / 5) + 32;
                if(output <= -456.07)
                {
                    Console.WriteLine(output +"F");
                    Console.WriteLine("Temperature below -456.07°F (absolute zero) does not exist on earth!");
                }
                Console.WriteLine(output +"F");
            }
            void ftoc()
            {
                double output = (F - 32) * 5 / 9;

               if(output <= -217.15)
                {
                    Console.WriteLine(output +"C");
                    Console.WriteLine("Temperature below -271.15°C (absolute zero) does not exist on earth!");
                }
                Console.WriteLine(output +"C");
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
