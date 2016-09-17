using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_BattingAverageCalculator;

namespace Lab8_BattingTest
{
    [TestClass]
    public class AverageTest
    {
        [TestMethod]
        public void TestBattingPercentageIs0WhenNoRuns()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;

            double battingAverage = Program.CalculateBattingAverage(battingSheet); //passing in battingSheet (array of integers), get back a double and name it. work from right to left. Right now returning 0.5, because defined inside method as 0.5.
            Assert.AreEqual(0, battingAverage);

            //average should be equal to 0 (expected), battingAverage=actual calculated by the method 
        }

        [TestMethod]
        public void TestBattingPercentageIs60()
        {
            int[] battingSheet = new int[5];

            ///write in actual program:
            //  for (int index = 0; index < battingSheet.Length; index++)
            // {

            //          battingSheet[index] = 0;
            // }


            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;


            double battingAverage = Program.CalculateBattingAverage(battingSheet); //passing in battingSheet (array of integers), get back a double and name it. work from right to left. Right now returning 0.5, because defined inside method as 0.5.
            Assert.AreEqual(0.6, battingAverage);
        }

        [TestMethod]
        public void TestSluggingPercentage()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 3;
            battingSheet[1] = 2;
            battingSheet[2] = 1;
            battingSheet[3] = 0;
            battingSheet[4] = 4;

            double sluggingAverage = Program.CalculateSluggingAverage(battingSheet);
            Assert.AreEqual(2, sluggingAverage);

        }
    }
}



/*

 Test1: Calculate Batting Percentage
 when you pass the method, don't have to include the type again. take and return should be same type. 
 */
