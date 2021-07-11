using System;

namespace UC_5_StopWatch
{
    class UC_5_StopWatch
    {

        static void Main(string[] args)
        {

          
            Console.WriteLine("Welcome to StopWatch Application! ");

            Console.WriteLine("..................................");

            Console.WriteLine("Enter the time in 24 hr format ");
            double startTime;
            Console.Write("Enter the start Timing :  ");
            startTime = double.Parse(Console.ReadLine());

            double endTime;
            Console.Write("Enter the end Timing :    ");
            endTime = double.Parse(Console.ReadLine());

            double Hour;
             Hour = endTime - startTime;

            double startMin = startTime * 60;
            double endMin = endTime * 60;
            double Min = endMin - startMin;

            double startSec = startTime *3600;
            double endSec = endTime *3600;
            double sec = endSec - startSec;

            double startMilliSec = startTime*3600*1000;
            double stopMilliSec = endTime *3600*1000;
            double milliseconds = stopMilliSec - startMilliSec;
           
            Console.WriteLine("Your elaspedTime is :" +Hour+":"+Min+":"+sec+":"+milliseconds);
            Console.ReadLine();
        }
    }
}

            