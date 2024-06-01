using System;
using System.IO;
namespace Interface
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("Mylog.txt"));

            monitor.start();
        }
    }
}
