using System.Globalization;

namespace AdventOfCode2022.Day1;

public class LogicDay1
{
    private List<Elf> Elves = new();
    private List<string> Inputs;

    public void ReadInputList(string path)
    {
        Inputs = File.ReadAllLines(path).ToList();
    }

    public void SeperateElves()
    {
        int elfCounter = 0;
        Elf currentElf = new Elf();
       
        foreach (string input in Inputs)
        {
            if (input != "")
            {
                int.TryParse(input, out int amount);
                currentElf.Index = elfCounter;
                currentElf.CaloriesOfElf.Add(amount);
            }
            else
            {
                Elves.Add(currentElf);
                currentElf = new Elf();
                elfCounter++;
            }
        }
    }

    public int ReturnElfWithMostCalories()
    {
        Elf currentMaxElf = new Elf();
        foreach (var elf in Elves)
        {
            if (currentMaxElf.CalculateCalories() < elf.CalculateCalories())
            {
                currentMaxElf = elf;
            }
        }

        return currentMaxElf.CalculateCalories();
    }

    public int ReturnTopThreeElvesCalories()
    {
        Elves.Sort((u1, u2) => u1.CalculateCalories().CompareTo(u2.CalculateCalories()));

        int sumOfTopThreeElves = 0;

        sumOfTopThreeElves += Elves[Elves.Count-1].CalculateCalories();
        sumOfTopThreeElves += Elves[Elves.Count-2].CalculateCalories();
        sumOfTopThreeElves += Elves[Elves.Count-3].CalculateCalories();

        return sumOfTopThreeElves;
    }

    public LogicDay1()
    {
        ReadInputList(@"C:\dev\AdventOfCode2022\Day1\inputs.txt");
        SeperateElves();
    }
}