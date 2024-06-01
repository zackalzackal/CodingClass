using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx02
{
    internal class Ryu : Fighter
    {
        public void kick() { Console.WriteLine("고유기능 : 풍차돌리기 킥"); }
    }
}
