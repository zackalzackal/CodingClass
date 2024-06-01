using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx01
{
    internal class Wolf : Monster
    {
        public void hit()
        {
            Console.WriteLine("Wolf Hit");
        }
    }
}
