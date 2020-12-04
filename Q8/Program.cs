using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{//    کمینه و بیشینه در یک آرایه را مشخص کند


    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Insert Size Of Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
             
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            int minNum = arr.Min();
            Console.WriteLine("Min => " + minNum);
            int maxNum = arr.Max();
            Console.WriteLine("Max => " + maxNum);

         //   int midNum = arr.Sum()/arr.Count();
          //  Console.WriteLine("Mid => " + midNum);

             Console.ReadLine();
        }
    }


}
