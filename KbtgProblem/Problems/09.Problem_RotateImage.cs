using KbtgProblem.Extensions;
using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbtgProblem.Problems
{
    public class Problem_RotateImage : IRunable
    {
        public void Run()
        {
            //int[,] q1 = new int[3, 3]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};
            //Solution(q1);
            //
            //int[,] q2 = new int[4, 4]
            //{
            //    { 5,  1,  9,  11 },
            //    { 2,  4,  8,  10 },
            //    { 13, 3,  6,  7  },
            //    { 15, 14, 12, 16 },
            //}; 
            //Solution(q2);
            //
            //int[,] q3 = new int[1, 1]
            //{
            //    { 1 }
            //};
            //Solution(q3);
            //
            //int[,] q4 = new int[2, 2]
            //{
            //    { 1, 2 },
            //    { 3, 4 }
            //};
            //Solution(q4);


            //int[][] q1 = new int[][]
            //{
            //    new int[]{ 1, 2, 3 },
            //    new int[]{ 4, 5, 6 },
            //    new int[]{ 7, 8, 9 }
            //};
            //Rotate(q1);
            int[][] q2 = new int[][]
            {
                new int[] { 5,  1,  9,  11 },
                new int[] { 2,  4,  8,  10 },
                new int[] { 13, 3,  6,  7  },
                new int[] { 15, 14, 12, 16 },
            };
            Rotate(q2);
        }

        public void Rotate(int[][] matrix)
        {
            int[][] buffer = matrix.Select(a => a.ToArray()).ToArray();
            int rows = matrix.Length;
            int cols = matrix[0].Length - 1;

            Debug.WriteLine($"before: {matrix.Print()}");
            int move = -1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = cols; j >= 0; j--)
                {
                    move = cols - j;
                    Debug.WriteLine($"from [{matrix[i][j]}]> {i}:{j}, to [{matrix[move][i]}]> {i}:{move}:");
                    matrix[i][j] = buffer[move][i];
                }
            }
            Debug.WriteLine($"after: {matrix.Print()}");
        }


        private void Solution(int[,] matrix)
        {
            int[,] buffer = (int[,])matrix.Clone();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1) - 1;
            int move = -1;
            Debug.WriteLine($"before: {matrix.Print()}");

            for (int i = 0; i < rows; i++)
            {
                for (int j = cols; j >= 0; j--)
                {
                    move = cols - j;
                    Debug.WriteLine($"from> {i}:{j}, to> {(cols-1)-j}:{i}");
                    matrix[i, j] = buffer[move, i];
                }
            }
            Debug.WriteLine($"after: {matrix.Print()}");
        }
    }
}
