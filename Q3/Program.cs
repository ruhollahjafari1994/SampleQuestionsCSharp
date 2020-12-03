using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> ls = new List<Student>();

            Console.WriteLine("Ensert Count Of Students : ");
            int Cycle =Convert.ToInt32(Console.ReadLine());
           

            for (int i = 0; i < Cycle; i++)
            {
                Console.WriteLine("Ensert Name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Ensert Grade : ");
                int Grade =Convert.ToInt32(Console.ReadLine());

                ls.Add(new Student( name,Grade));
            }
            foreach (var item in ls)
            {
                if (item.Grade==20)
                {
                    Console.WriteLine( "Name : " + item.Name +"   Grade : " + item.Grade);
                }
            }
            Console.ReadLine();
        }
    }
  public  class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student()
        {

        }
        public Student(string name , int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
