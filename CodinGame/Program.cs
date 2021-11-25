using CodinGame.Interfaces;
using CodinGame.Problems;
using System;

namespace CodinGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var prob = new Problem_DetectiveGeek();
            //var prob = new Problem_TemperatureClosestToZero();
            var prob = new Problem_AsciiArt();
            prob.Run();

            Console.ReadLine();
        }
    }
}
