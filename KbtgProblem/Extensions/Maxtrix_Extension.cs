using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbtgProblem.Extensions
{
    public static class Maxtrix_Extension
    {
        public static string Print(this int[][] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.Length; i++)
            {
                var row = matrix.GetRow(i);
                sb.Append($"[{string.Join(",", row)}]");
            }
            return $"[{sb.ToString()}]";
        }

        public static string Print(this int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = matrix.GetRow(i);
                sb.Append($"[{string.Join(",", row)}]");
            }
            return $"[{sb.ToString()}]";
        }


        public static int[] GetColumn(this int[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public static int[] GetRow(this int[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

        public static int[] GetColumn(this int[][] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.Length)
                    .Select(x => matrix[x][columnNumber])
                    .ToArray();
        }

        public static int[] GetRow(this int[][] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.Length)
                    .Select(x => matrix[rowNumber][x])
                    .ToArray();
        }
    }
}
