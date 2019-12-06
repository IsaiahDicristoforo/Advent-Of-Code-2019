using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2019
{
    class Day01Problem01
    {
        public static double SolveProblemOne()
        {
            //Sources:
            //https://stackoverflow.com/questions/22086692/get-sum-of-the-value-from-list-using-linq

            return File.ReadAllLines("../../DayOneFiles/Mass.txt").Sum(x => (Math.Floor(Convert.ToDouble(x) / 3.0)) - 2);
        } 

       
    }
}
