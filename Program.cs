#define DAY2

using AdventOfCode2022.Day1;
using AdventOfCode2022.Day2;

namespace AdventOfCode2022
{
    public class AdventOfCode
    {
        
        public static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("#################################################################################");
            Console.WriteLine("Solutions for Advent of Code 2022 by FrittenIngenieur");
            Console.WriteLine("#################################################################################");
            
            #if DAY1
            Console.WriteLine("--- Solution Day 1 ---");
            LogicDay1 logicDay1 = new LogicDay1();
            Console.WriteLine("Elf with most Calories has: " + logicDay1.ReturnElfWithMostCalories());
            Console.WriteLine("Top three Elves with most Calories: " + logicDay1.ReturnTopThreeElvesCalories());
            Console.WriteLine("--- End of Day 1 ---");
            
            #elif DAY2
            Console.WriteLine("--- Solution Day 2 ---");
            LogicDay2 logicDay2 = new LogicDay2();
            Console.WriteLine("Total score of Rock, Scissor, Paper: " + logicDay2.CalculateWinScore());
            Console.WriteLine("Total score of Rock, Scissor, Paper - Part2: " + logicDay2.CalculateWinScorePart2());
            Console.WriteLine("--- End of Day 2 ---");
            
            #endif
            
        }
    }
}


