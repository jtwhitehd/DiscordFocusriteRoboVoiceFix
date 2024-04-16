using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string processName = "audiodg";
        IntPtr affinity = (IntPtr)1; // Use only the first core

        while (true)
        {
            try
            {
                Process process = Process.GetProcessesByName(processName).FirstOrDefault(); // find process
                if (process != null)
                {
                    if (process.ProcessorAffinity != affinity)
                    {
                        Console.WriteLine($"[{DateTime.Now}]  |  Adjusted processor affinity for {processName}.");
                        process.ProcessorAffinity = affinity;
                    }
                    else
                    {
                        Console.Write("."); // each . in the log will represent a passed check
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Thread.Sleep(300_000);  // 5 minute delay
        }
    }
}