using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2019
{
    public class DayOne
    {

        public static double SolveDay1Part1()
        {
            //Sources:
            //https://stackoverflow.com/questions/22086692/get-sum-of-the-value-from-list-using-linq

            return File.ReadAllLines("../../DayOneFiles/Mass.txt").Sum(x => (Math.Floor(Convert.ToDouble(x) / 3.0)) - 2);
        }

        public static double SolveDay1Part2()
        {

            double totalFuel = 0;

            double[] masses = File.ReadAllLines("../../DayOneFiles/Mass.txt").Select(x => Convert.ToDouble(x)).ToArray();

            foreach (var mass in masses)
            {
                double fuel = Math.Floor(((mass)) / 3.0) - 2;  //Initial Fuel
                totalFuel += fuel;  //Add to total
                while (fuel >= 0)
                {
                    fuel = Math.Floor(fuel / 3.0) - 2;

                    if (fuel > 0)
                    {
                        totalFuel += fuel;

                    }
                }

            }

            return totalFuel;
        }

      
    }
}
