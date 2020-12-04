using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{//برنامه ای بنویسید که اعداد بین دو عدد را نمایش دهد
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> ls = new List<Students>();
            for (int i = 0; i < 999; i++)
            {
            Students students = new Students(i);
                ls.Add(students);
            }
            foreach (Students item in ls) //find between 10 and 13
            {
                if (item.Id<13 && item.Id > 10)
                {
                    Console.WriteLine("Find.... => " + item.Id );
                }
            }
            Console.ReadLine();
        }
    }
    class Students
    {
        public int Id { get; set; }
        public Students(int id)
        {
            Id = id;
        }
    }
}
