using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BattingAverageCalculator
{
    public class Program
    {

        static string keepGoing;
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Batting Average Calculator!");
            do
            {
              
                Console.WriteLine("\nEnter number of times at bat: ");

                int batNum = int.Parse(Console.ReadLine())+1;

                int[] battingSheet = new int[batNum];
    
                //int iCount=0;
                for (int iCount = 1; iCount < batNum; iCount++)
                {     
                  
                    Console.Write("Result for at-bat "+iCount +": ");
                    battingSheet[iCount] = int.Parse(Console.ReadLine());
                }

                /*Console.Write("Result for at-bat 2: ");
                battingSheet[1] = int.Parse(Console.ReadLine());
                Console.Write("Result for at-bat 3: ");
                battingSheet[2] = int.Parse(Console.ReadLine());
                Console.Write("Result for at-bat 4: ");
                battingSheet[3] = int.Parse(Console.ReadLine());
                Console.Write("Result for at-bat 5: \n");
                battingSheet[4] = int.Parse(Console.ReadLine());
                */

                //double Average = CalculateBattingAverage(battingSheet);
                //Console.WriteLine(Average);

                Console.WriteLine("\nBatting average: " + CalculateBattingAverage(battingSheet));
                Console.WriteLine("Slugging average: " + CalculateSluggingAverage(battingSheet) + "\n");

                continueOrQuit();
                
            } while (keepGoing.ToLower() == "y" || keepGoing.ToLower() == "yes");

        }

        public static double CalculateBattingAverage(int[] battingSheet)
        {
            int hit = 0;

            for (int i = 0; i < battingSheet.Length; i++)
            {
          
               // battingSheet[index] = 0;

                if (battingSheet[i] > 0)
                {
                    hit = hit + 1;
                }
            }
                       
             double batAvg = (double) hit / battingSheet.Length;
             return Math.Round(batAvg, 3);
            //return 0.0; //to pass the 1st test
            //return 0.5;

        }

        public static double CalculateSluggingAverage(int[] battingSheet)
        {
            int sum = 0;

            for (int i = 0; i < battingSheet.Length; i++)
            {
                sum += battingSheet[i];
            }

            double sluggingAvg = (double) sum / battingSheet.Length;
            return Math.Round(sluggingAvg, 3);

        }

        private static void continueOrQuit()
        {
            Console.WriteLine("Another batter? (y/n)");
            keepGoing = Console.ReadLine();
        }


    }
}
/*

            int successAtBat = 0;
            for (int i = 0; i < battingSheet.Length;i++)
            { if (battingSheet[1] > 0)
                   successAtBat++;
             }
            return (double)successAtBat / battingSheet.Length;

 * 3/5=0
Return numberator/denominator
Return (double) numberofHits/numberOfAttempts


    for (int i = 0; i < batting.Length; i++)
            {
                expNetStudents[i] = new Student();
            }

 This method calculates batting average, give it array of integers, that returns double
 methods go inside class

Enter number of times at bat:
2 3 4 4 4 

1 0 3 4 2 

    batting sheet array
    array of integers
    Index = At Bat 0,1,2,3,4
    Value = Runs Earned 
 */
