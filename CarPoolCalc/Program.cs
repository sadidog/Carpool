using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //collect user data
            Console.WriteLine("how many miles a day to you drive on average?");
            int avrMilesDriven = int.Parse(Console.ReadLine());

            Console.WriteLine("how much in cents does your gas cost you  on average?");
            int avrCostGallonGas = int.Parse(Console.ReadLine());

            Console.WriteLine("what is your average MPG?");
            int avrMilesPerGallon = int.Parse(Console.ReadLine());

            Console.WriteLine("what do you pay daily parking fees?");
            int dailyParkingFees = int.Parse(Console.ReadLine());

            Console.WriteLine("what do you pay daily in road tolls?");
            int dailyRoadTolls = int.Parse(Console.ReadLine());

            Console.WriteLine("how may days a month will you car pool?");
            int carPoolingDays = int.Parse(Console.ReadLine());

            //calculate costs per day savings. 

            int savings = (((avrMilesDriven / avrMilesPerGallon) * avrCostGallonGas) + (dailyParkingFees + dailyRoadTolls)) * carPoolingDays;
            int costPerDay = ((avrMilesDriven / avrMilesPerGallon) * avrCostGallonGas);
            Console.WriteLine($"your cost per day for driving to work is {costPerDay}"); 
            Console.WriteLine($"your savings if you carpool {carPoolingDays} days a month is {savings}");
            Console.ReadLine();

        }
    }
}
