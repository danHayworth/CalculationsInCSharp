using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Calculations
    {
        static void Main(string[] args)
        {
            void spaceInBetween()
            {
                Console.WriteLine(" \n Next Calculation \n ");
            }
            CheckTwoNumbersDivisibleByTwoOrThree();
            spaceInBetween();
            AreaAndVolumeOfSphereByRadiusInput();
            spaceInBetween();
            MultiplicationTableToTenByInput();
            spaceInBetween();
            AddLessDivisionMultiplicationModulo();
            spaceInBetween();
            SpeedCalculationMetersKilometersMiles();
            spaceInBetween();
            SumAverageOfArraysWithTenNumbersInput();
            spaceInBetween();
            TemperatureFromCtoFAndViceversa();
            Console.ReadLine();
        }
        static void CheckTwoNumbersDivisibleByTwoOrThree()
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
            if (divi == true)
            {
                Console.WriteLine("Multiplicated " + (num1 * num2));
            }
            else
            {
                Console.WriteLine("Sum " + (num1 + num2));
            }

            void calc()
            {
                if (num1 % 2 == 0 || num1 % 3 == 0 && num2 % 2 == 0 || num2 % 3 == 0)
                {
                    divi = true;
                }
                else
                {
                    divi = false;
                }
            }
        }
        static void AreaAndVolumeOfSphereByRadiusInput()
        {
            Console.WriteLine("Enter the radius");
            double radius = Double.Parse(Console.ReadLine());
            double A = 4 * Math.PI * Math.Pow(radius, 2);
            double V = (4 * Math.PI) / 3 * Math.Pow(radius, 3);
            Console.WriteLine("Area of the sphere: " + A);
            Console.WriteLine("Volume of the sphere: " + V);
        }
        static void MultiplicationTableToTenByInput()
        {
            int a;
            Console.WriteLine("Let's do multiplication table by a number you choose");
            a = Int32.Parse(Console.ReadLine());
            int[] b = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, j, (a * j));
            }

        }
        static void AddLessDivisionMultiplicationModulo()
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
        }
        static void SpeedCalculationMetersKilometersMiles()
        {
            Console.WriteLine("Enter distance in meters!");
            double distance = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many hours did you drive!");
            double hour = Double.Parse(Console.ReadLine());
            double minutes;
            do
            {
                Console.WriteLine("Enter how many minutes did u drive!");
                minutes = Double.Parse(Console.ReadLine());

            } while (minutes >= 60);

            double seconds;
            do
            {
                Console.WriteLine("Enter how many seconds did you drive!");
                seconds = Double.Parse(Console.ReadLine());

            } while (seconds >= 60);

            double timeInSec = (hour * 3600) + (minutes * 60) + seconds;
            double mps = distance / timeInSec;
            Console.WriteLine("your speed in meters per second: " + String.Format("{0:0.00}", mps) + " mps");
            double kph = (mps * 3.6);
            Console.WriteLine("your speed in kilometers per hour: " + String.Format("{0:0.00}", kph) + " kph");
            double mph = (kph / 1.609);
            Console.WriteLine("your speed in miles per hour: " + String.Format("{0:0.00}", mph) + " mph");
        }
        static void SumAverageOfArraysWithTenNumbersInput()
        {
            Console.WriteLine("Enter 10 numbers. Each time when u enter a number press enter then carry on.")
            int[] answer = new int[10];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("The sum is " + answer.Sum());
            Console.WriteLine("The average is " + answer.Average());
        }
        static void TemperatureFromCtoFAndViceversa()
        {
            double C = 0;
            double F = 0;

            Console.WriteLine("What would you like to transform into? \nC or F");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "C")
            {
                Console.WriteLine("What is the F temperature?");
                string faren = Console.ReadLine();
                F = Convert.ToDouble(faren);
                ftoc();
            }
            else if (answer.ToUpper() == "F")
            {
                Console.WriteLine("What is the C temperature?");
                string celsi = Console.ReadLine();
                C = Convert.ToDouble(celsi);
                ctof();
            }

            void ctof()
            {
                double output = (C * 9 / 5) + 32;
                if (output <= -456.07)
                {
                    Console.WriteLine(output + "F");
                    Console.WriteLine("Temperature below -456.07°F (absolute zero) does not exist on earth!");
                }
                Console.WriteLine(output + "F");
            }
            void ftoc()
            {
                double output = (F - 32) * 5 / 9;

                if (output <= -217.15)
                {
                    Console.WriteLine(output + "C");
                    Console.WriteLine("Temperature below -271.15°C (absolute zero) does not exist on earth!");
                }
                Console.WriteLine(output + "C");
            }
        }
        
    }
}
