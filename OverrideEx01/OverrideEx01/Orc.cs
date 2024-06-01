using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx01
{
    internal class Orc : Monster
    {
        public override void hit()
        {
            Console.WriteLine("Orc Hit");
        }
    }
}
