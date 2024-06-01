using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx01
{
    internal class Elf : Monster    
    {
        public new void hit()
        {
            Console.WriteLine("Elf Hit");
        }
    }
}
