using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string[] Menu = { "1 - Get Member Of Array", "2 - Show Array", "3 - Sorting Array", "4 - Reverce Member Of Array", "5 - Linear Search", "6 - Binary Search", "7 - Exit" };

            bool Cycle = true;
            while (Cycle == true)
            {
                foreach (var item in Menu)
                {
                    Console.WriteLine(item);
                }

                int MenuNum = Convert.ToInt32(Console.ReadLine());
                if (MenuNum == 1)//1 - Get Member Of Array
                {
                    Calculating.GetArray();
                }
                else if (MenuNum == 2)//2 - Show Array
                {
                    Calculating.ShowArray();
                }
                else if (MenuNum == 3)
                {
                    Calculating.SortArray();
                }
                else if (MenuNum == 4)
                {
                    Calculating.ReverseArray();
                }
                else if (MenuNum == 5)
                {
                    Console.WriteLine("Insert Your Number To Be FInd (Linear Search) ...");
                   int n =Convert.ToInt32(Console.ReadLine());
                    Calculating.LinearSearchArray(n);
                }
                else if (MenuNum == 6)
                {
                    Console.WriteLine("Insert Your Number To Be FInd(Binary Search) ...");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Calculating.BinarySearchArray(n);
                }
                else if (MenuNum == 7)
                {
                    Cycle = false;
                }
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

    }

    public static class Calculating
    {
        public static int[] MyArray { get; set; }
        public static void GetArray()
        {
            Console.WriteLine("Enter Size Of Array :");
            int SizeArray = Convert.ToInt32(Console.ReadLine());
            int[] arrayname = new int[SizeArray];
            for (int i = 0; i < SizeArray; i++)
            {
                Console.WriteLine("Insert Number => " + i + "   Of Array  ");
                arrayname[i] = Convert.ToInt32(Console.ReadLine());
                MyArray = arrayname;
            }
        }
        public static void ShowArray()
        {
            foreach (var item in MyArray)
            {
                Console.WriteLine(" ==> "+item);
            }
        }
        public static void SortArray()
        {
            Array.Sort(MyArray);
            foreach (var item in MyArray)
            {
                Console.WriteLine(" ==> "+item + " ");
            }
        }
         public static void ReverseArray()
        {
            Array.Reverse(MyArray);    
            foreach (var item in MyArray)
            {
                Console.WriteLine(" ==> " + item + " ");
            }
        }
        public static void LinearSearchArray(int n )
        {
            Array.Sort(MyArray);
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i]==n)
                {
                    Console.WriteLine("************ Find Your Number ! *************");
                }
                else
                {
                    break;
                 }
            }
        }
        public static void BinarySearchArray(int n)
        {
            Array.Sort(MyArray);
            int minNum = 0;
            int maxNum = MyArray.Length - 1;
            while (minNum<=maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (n==MyArray[mid])
                {
                       ++mid;
                    Console.WriteLine("Find Yor Number ..." + mid + "   Of Array");
                    break;
                 }
                else if (n<MyArray[mid])
                {
                    maxNum = mid - 1;
                }
                else if(n > MyArray[mid])
                {
                    minNum = mid + 1;
                }
                else
                {
                Console.WriteLine("Not Found ...");
                    break;
                 }
             }
        }
    }
}
