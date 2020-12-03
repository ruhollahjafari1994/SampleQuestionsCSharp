using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;



namespace too
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Days = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            List<int> month = new List<int>();
            double Week;
            double Average;
            List<int> ls = new List<int>();
            List<int> BigPayment = new List<int>();

            for (int i = 1; i <= Days.Length; i++)
            {
    Console.WriteLine("Enter Your  Payment "+ i + " : " );
                 int result = Int32.Parse(Console.ReadLine());
                ls.Add(result);
            }
                int sum = ls.Sum();
                Console.WriteLine("Sum Of 30 Days : " + sum);
            Console.ReadLine();
            Console.WriteLine("Press Enter ... ");
            Average = sum / 30;
            Console.WriteLine("Average of every Day : " + Average);
            Console.ReadLine();
            Console.WriteLine("Press Enter ... ");

            foreach (var m in ls) //month
            {
                if (m>Average)
                {
                    BigPayment.Add(m);
                }
            }
          
            Console.WriteLine("Count Of VelKharji : " +  BigPayment.Count());
            Console.ReadLine();
    
        }
    }
}
