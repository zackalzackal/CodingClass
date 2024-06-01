using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx02
{
    internal class Guile : Fighter
    {
        public void kick() { Console.WriteLine("Guild 회오리킥"); }
        public override void energy() { Console.WriteLine("부메랑 모양 장풍"); }
    }
}
