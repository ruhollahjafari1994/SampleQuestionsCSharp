using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            System.Diagnostics.Process CurrentProc = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process item in proc)
            {
                i++;
                Console.WriteLine("item Number " + i + " Of  " + item);
                Console.WriteLine("------------------------------------------------------------------------------------------------****************");
            }
            Console.WriteLine(" Count Of Running Programms Now :=> " + i);
 

        }
    }
}
