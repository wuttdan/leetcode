using KbtgProblem.Interfaces;
using KbtgProblem.Problems;
using System;

namespace KbtgProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var prob = (IRunable)new Problem_ArmyReport();
            //var prob = (IRunable)new Problem_DigitalClock();
            //var prob = (IRunable)new Problem_FileTypeBytes();
            //var prob = (IRunable)new Problem_GlassessOfWater(); 
            //var prob = (IRunable)new Problem_PhoneNumber();
            //var prob = (IRunable)new Problem_DifferentNumberDivineBy3();
            //var prob = (IRunable)new Problem_SwappingNode();
            //var prob = (IRunable)new Problem_NextGreaterNode();
            //var prob = (IRunable)new Problem_NextGreaterNode();

            var prob = (IRunable)new Problem_RotateImage();
            //var prob = (IRunable)new Problem_SmallestInterger();
            prob.Run();

            Console.ReadLine();
        }
    }
}
