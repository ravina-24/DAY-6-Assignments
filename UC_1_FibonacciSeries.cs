using System;

namespace UC_1_FibonacciSeries
{
    class UC_1_FibonacciSeries
    {
        static void Main(string[] args)
        {
            int Num;

            Console.Write("Enter the number of elements :    ");
            Num = int.Parse(Console.ReadLine());



            int f1 = 0, f2 = 1;
            int fSeries;
            int i;
            Console.WriteLine("Fibonacci sequence : " + f1);
            Console.WriteLine("Fibonacci sequence : " + f2);
            for (i =2; i <Num; i++)
            {
                fSeries = f1 + f2;
                Console.WriteLine("Fibonacci sequence : " + fSeries);
                f1 = f2;
                f2 = fSeries;

                
                
            }
            Console.ReadLine();
        }
    }
}
