using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Process CurrentProc = Process.GetCurrentProcess();
            Process[] proc = Process.GetProcesses();
            foreach (Process item in proc)
            {
                if (CurrentProc.ProcessName == item.ProcessName) 
                {
                    i++;
                }
                if (i>1)
                {
                    Console.WriteLine("Press any Key To Exit...");
                    Console.ReadLine();

                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
