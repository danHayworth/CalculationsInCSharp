using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Speed
    {
        static void Main(string[] args)
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
                Console.WriteLine("your speed in meters per second: " + String.Format("{0:0.00}", mps)+" mps");
            double kph = (mps * 3.6);
                Console.WriteLine("your speed in kilometers per hour: " + String.Format("{0:0.00}", kph) + " kph");
            double mph = (kph/1.609);
                Console.WriteLine("your speed in miles per hour: " + String.Format("{0:0.00}", mph) + " mph");



            Console.ReadLine();
        }
    }
}
