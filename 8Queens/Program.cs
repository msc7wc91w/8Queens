using System;

namespace _8Queens
{
    class Program
    {
        const int QUEENNUM = 8;
        static int[] row = new int[QUEENNUM];
        static int iCount = 1;

        public static void Main()
        {
            Queens(0);
        }

        private static void Queens(int n)
        {
            if (n == QUEENNUM)
            {
                Output();
                return;
            }
            for (int i = 0; i < QUEENNUM; i++)
            {
                row[n] = i;
                bool conflict = false;
                for (int j = 0; j < n; j++)
                {
                    //跟前面放好的皇后位置比，若任何一個位置衝突
                    if (row[j] == row[n] || Math.Abs(row[j] - row[n]) == (n - j))
                    {
                        conflict = true;
                        break;
                    }
                }
                if (!conflict)
                    Queens(n + 1);
            }
        }

        private static void Output()
        {
            Console.Write($"//Solution {iCount}\n");
            iCount++;
            for (int i = 0; i < QUEENNUM; i++)
            {
                for (int j = 0; j < QUEENNUM; j++)
                {
                    if (row[i] == j)
                    {
                        Console.Write("Q");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
