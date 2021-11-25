using KbtgProblem.Extensions;
using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbtgProblem.Problems
{
    public class Problem_CyclicRotation : IRunable
    {
        //https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
        public void Run()
        {
            var q = new List<(int[], int)>
            {
                //(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8}, 30)
                (new int[]{ 3, 8, 9, 7, 6}, 3),
                (new int[]{ 0, 0, 0},       1),
                (new int[]{ 1, 2, 3, 4},    4),
                (new int[]{ 3, 8, 9, 7, 6, 5}, 15)//7, 6, 5, 3, 8, 9
            };
            int i = 0;
            foreach ((int[] A, int K) in q)
            {
                Debug.WriteLine($"answer {i}: {Solution(A, K).Print()}");
                i++;
            }
        }

        public int[] Solution(int[] A, int K)
        {
            int allLength = A.Length;
            int[] result = new int[allLength];
            int index = 0;

            for (int i = 0; i < allLength; i++)
            {
                index = K + i;
                result[index %= allLength] = A[i];
            }

            return result;
        }

        //3, original java, https://app.codility.com/demo/results/trainingTM9JJC-5ZQ/
        public int[] solution(int[] A, int K)
        {
            int aLength = A.Length;
            int[] B = new int[aLength];
            int x = 0;

            for (int i = 0; i < aLength; i++)
            {
                x = K + i;
                if (x >= aLength) x -= (int)(Math.Floor((decimal)(x / aLength)) * aLength);
                B[x] = A[i];
            }

            return B;
        }

        //2
        //public int[] Solution(int[] A, int K)
        //{
        //    if (A.Length == K) return A;
        //    if (A.All(x => x == A[0])) return A;
        //    if (K > A.Length) K = K % A.Length;
        //
        //    List<int> results = new List<int>();
        //
        //    for (int i = 0; i < K; i++)
        //    {
        //        if (i != 0)
        //        {
        //            A = results.ToArray();
        //            results.Clear();
        //        }
        //        for (int j = 0; j < A.Length - 1; j++)
        //        {
        //            results.Add(A[j]);
        //        }
        //        results.Insert(0, A.Last());
        //    }
        //    return results.ToArray();
        //}

        //1
        //public int[] Solution(int[] A, int K)
        //{
        //    if (A.Length == K) return A;
        //    if (A.All(x => x == A[0])) return A;
        //
        //    var result = new int[A.Length];
        //
        //    for (int i = 0; i < K; i++)
        //    {
        //        for (int j = 1; j < A.Length; j++)
        //        {
        //            result[j] = A[j - 1];
        //        }
        //        result[0] = A[A.Length - 1];
        //        A = result.ToArray();
        //    }
        //    return result;
        //}
    }

}
