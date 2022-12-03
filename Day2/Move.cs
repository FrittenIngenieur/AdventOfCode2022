using System.Runtime.Intrinsics.X86;

namespace AdventOfCode2022.Day2;

// A for Rock
// B for Paper
// C for Scissors.

// X for Rock
// Y for Paper
// Z for Scissors

// 1 for Rock
// 2 for Paper
// 3 for Scissors

public class Move
{
    public string OpponentMove { get; set; }
    public string MyMove { get; set; }

    public Move(string oppMove, string myMove)
    {
        OpponentMove = oppMove;
        MyMove = myMove;
    }

    public int GetPointsOfMove()
    {
        switch (OpponentMove)
        {
            case "A":
                switch (MyMove)
                {
                    case "X":
                        return 1+3;
                    case "Y":
                        return 2+6;
                    case "Z":
                        return 3;
                }
                return 0;
            case "B":
                switch (MyMove)
                {
                    case "X":
                        return 1;
                    case "Y":
                        return 2+3;
                    case "Z":
                        return 3+6;
                }
                return 0;
            case "C":   
                switch (MyMove)
                {
                    case "X":
                        return 1+6;
                    case "Y":
                        return 2;
                    case "Z":
                        return 3+3;
                }
                return 0;
            default: return 0;
        }
    }
    
    // A for Rock
    // B for Paper
    // C for Scissors.

    // X lose
    // Y draw
    // Z win
    public int GetPointsOfMoveTheRightWay()
    {
        switch (OpponentMove)
        {
            case "A":
                switch (MyMove)
                {
                    case "X":
                        return 3;
                    case "Y":
                        return 1+3;
                    case "Z":
                        return 6+2;
                }
                return 0;
            case "B":
                switch (MyMove)
                {
                    case "X":
                        return 1;
                    case "Y":
                        return 2+3;
                    case "Z":
                        return 6+3;
                }
                return 0;
            case "C":   
                switch (MyMove)
                {
                    case "X":
                        return 2;
                    case "Y":
                        return 3+3;
                    case "Z":
                        return 6+1;
                }
                return 0;
            default: return 0;
        }
    }
}