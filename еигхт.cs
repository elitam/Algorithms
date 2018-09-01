using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    class Program
    {
        static char[,] labyrinth;
        static List<char> path;

        static void Main(string[] args)
        {
            ReadLabyrinth();
            FindPaths(0, 0, 'S');

        }
        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }

            path.Add(direction);

            if (IfExit(row, col))
            {
                PrintPath();
            }
            else if (IsFree(row, col))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');
                Unmark(row, col);
            }

            path.RemoveAt(path.Count - 1);

        }

        private static void Unmark(int row, int col)
        {
            labyrinth[row, col] = '-';
        }

        private static void Mark(int row, int col)
        {
            labyrinth[row, col] = 'v';
        }

        private static bool IsFree(int row, int col)
        {
            return labyrinth[row, col] == '-';
        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join(String.Empty, path.Skip(1)));
        }

        private static bool IfExit(int row, int col)
        {
            return labyrinth[row, col] == 'e';
        }

        private static bool IsInBounds(int row, int col)
        {
            bool rowInBounds = row >= 0 && row < labyrinth.GetLength(0);
            bool colInBounds = col >= 0 && col < labyrinth.GetLength(1);

            return rowInBounds && colInBounds;
        }

        private static void ReadLabyrinth()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            labyrinth = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                String line = Console.ReadLine();
                for (int c = 0; c < col; c++)
                {
                    labyrinth[r, c] = line[c];
                }
            }

            path = new List<char>();
        }
    }
}
