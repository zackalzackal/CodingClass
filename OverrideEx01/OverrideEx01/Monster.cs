using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx01
{
    internal class Monster
    {
        public virtual void hit()
        {
            Console.WriteLine("Monster Hit");
        }
    }
}
