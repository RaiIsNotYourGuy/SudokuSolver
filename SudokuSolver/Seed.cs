using System.Runtime.InteropServices;

namespace SudokuSolver;

public class Seed
{
    public static int[,] FirstSeed()
    {
        //Hard coded seed
        int[,] seed =
        {
            { 0, 4, 9, 0, 0, 8, 6, 0, 5 }, { 0, 0, 3, 0, 0, 7, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 3, 0 },
            { 0, 0, 0, 4, 0, 0, 8, 0, 0 }, { 0, 6, 0, 8, 1, 5, 0, 2, 0 }, { 0, 0, 1, 0, 0, 9, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 6, 0, 0, 4, 0, 0 }, { 8, 0, 4, 5, 0, 0, 3, 9, 0 }
        };
        return seed;
    }

    public static int[,] SecondSeed()
    {
        int[,] seed =
        {
            { 0, 1, 6, 4, 0, 0, 0, 0, 0 }, { 2, 0, 0, 0, 0, 9, 0, 0, 0 }, { 4, 0, 0, 0, 0, 0, 0, 6, 2 },
            { 0, 7, 0, 2, 3, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0, 0, 3 }, { 0, 0, 3, 0, 8, 7, 0, 4, 0 },
            { 9, 6, 0, 0, 0, 0, 0, 0, 5 }, { 0, 0, 0, 8, 0, 0, 0, 0, 7 }, { 0, 0, 0, 0, 0, 6, 8, 2, 0 }
        };
        return seed;
    }

    public static int[,] UnsolvableSeed()
    {
        int[,] seed =
        {
            { 0, 2, 6, 4, 0, 0, 0, 0, 0 }, { 2, 0, 0, 0, 0, 9, 0, 0, 0 }, { 4, 0, 0, 0, 0, 0, 0, 6, 2 },
            { 0, 7, 0, 2, 3, 0, 1, 0, 0 }, { 1, 0, 0, 0, 0, 0, 0, 0, 3 }, { 0, 0, 3, 0, 8, 7, 0, 4, 0 },
            { 9, 6, 0, 0, 0, 0, 0, 0, 5 }, { 0, 0, 0, 8, 0, 0, 0, 0, 7 }, { 0, 0, 0, 0, 0, 6, 8, 2, 0 }
        };
        return seed;
    }

    public static int[,] ValidationSeed()
    {
        int[,] seed = new int[,]
        {
            { 4, 6, 7, 9, 2, 1, 3, 5, 8, }, { 8, 9, 5, 4, 7, 3, 2, 6, 1 }, { 2, 3, 1, 8, 6, 5, 7, 4, 9 },
            { 5, 1, 3, 6, 9, 8, 4, 2, 7 }, { 9, 2, 8, 7, 5, 4, 6, 1, 3 }, { 7, 4, 6, 1, 3, 2, 9, 8, 5 },
            { 3, 5, 4, 2, 8, 7, 1, 9, 6 }, { 1, 8, 9, 3, 4, 6, 5, 7, 2 }, { 6, 7, 2, 5, 1, 9, 8, 3, 4 }
        };
        return seed;
    }
}