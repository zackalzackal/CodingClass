using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedInterface
{
    internal class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(),message);
        }

        public void WriteLog(string format,params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(),message);
        }
    }
}
