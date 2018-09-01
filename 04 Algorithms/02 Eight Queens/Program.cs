using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Eight_Queens
{
    class Program
    {
        const int chessboardSize = 8;
        static int solutionFound = 0;
        static bool[,] chessboard = new bool[chessboardSize, chessboardSize];
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColums = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();


        static void Main(string[] args)
        {
            PutQueens(0);
            Console.WriteLine(solutionFound);
        }

        static void PutQueens(int row)
        {
            if (row == chessboardSize)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < chessboardSize; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPosition(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPosition(row, col);
                    }
                }
            }
        }



        static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied =
                attackedRows.Contains(row) ||
                attackedColums.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals.Contains(col + row);
            return !positionOccupied;

        }

        static void MarkAllAttackedPosition(int row, int col)
        {
            attackedRows.Add(row);
            attackedColums.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(col + row);
            chessboard[row, col] = true;
        }

        static void UnmarkAllAttackedPosition(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColums.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
            chessboard[row, col] = false;
        }

        static void PrintSolution()
        {
            for (int row = 0; row < chessboardSize; row++)
            {
                for (int col = 0; col < chessboardSize; col++)
                {

                    Console.WriteLine(chessboard[row, col] ? "*" : "-");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionFound++;
        }
    }
}