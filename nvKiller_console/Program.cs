using System;
using System.Diagnostics;
namespace nvKiller_console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                nvKill(Process.GetProcessesByName("nvcagent.npc"), Process.GetProcessesByName("nsvmon.npc"), Process.GetProcessesByName("nsavsvc.npc"));
            }
        }
        static void nvKill(Process[] p1, Process[] p2, Process[] p3)
        {
            try
            {
                if ((p1.Length > 0 || p2.Length > 0) || p3.Length > 0)
                {
                    p1[0].Kill(); p2[0].Kill(); p3[0].Kill();
                    Console.WriteLine("Killed");
                }
                else
                {
                    Console.WriteLine("Searching...");
                }
            }
            catch
            {

            }
        }
    }
}
