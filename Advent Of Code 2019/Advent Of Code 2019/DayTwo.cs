﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2019
{
    class DayTwo
    {

        public static int SolveDayTwoPartOne()
        {



            int[] input = ("1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,13,1,19,1,6,19,23,2,23,6,27,1,5,27,31,1,10,31,35,2,6,35,39,1" +
                          ",39,13,43,1,43,9,47,2,47,10,51,1,5,51,55,1,55,10,59,2,59,6,63,2,6,63,67,1,5,67,71,2,9,71,75,1,75,6,79,1,6,79,83,2,83" +
                          ",9,87,2,87,13,91,1,10,91,95,1,95,13,99,2,13,99,103,1,103,10,107,2,107,10,111,1,111,9,115,1,115,2,119,1,9,119,0,99,2,0,14,0")
            .Split(',').Select(x => Convert.ToInt32(x)).ToArray();


            //The end of this problem says to replace these elements for some reasons before we run the opcode sequence.
            input[1] = 12;  
            input[2] = 2;

            int opcodeStartIndex = 0;

            while (input[opcodeStartIndex] != 99)
            {

                if (input[opcodeStartIndex] == 1)
                {
                    input[input[opcodeStartIndex + 3]] = input[input[opcodeStartIndex + 1]] + input[input[opcodeStartIndex + 2]];
                    
                }else if (input[opcodeStartIndex] == 2)
                {
                    input[input[opcodeStartIndex + 3]] = input[input[opcodeStartIndex + 1]] * input[input[opcodeStartIndex + 2]];


                }

                opcodeStartIndex += 4;
            }

            return input.First();

        }
    
}
}

