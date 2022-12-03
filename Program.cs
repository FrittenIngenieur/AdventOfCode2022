using AdventOfCode2022.Day1;

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

            Console.WriteLine("--- Solution Day 1 ---");
            LogicDay1 logicDay1 = new LogicDay1();
            Console.WriteLine("Elf with most Calories has: " + logicDay1.ReturnElfWithMostCalories());
            Console.WriteLine("Top three Elves with most Calories: " + logicDay1.ReturnTopThreeElvesCalories());
            Console.WriteLine("--- End of Day 1 ---");
            
        }
    }
}


