using System;

namespace OverrideEx02
{
    internal class Fighter
    {
        public void forward() { Console.WriteLine("Forward"); }
        public void backward() { Console.WriteLine("Backward"); }
        public void jump() { Console.WriteLine("Jump"); }
        public void seat() { Console.WriteLine("Seat"); }
        public virtual void energy() { Console.WriteLine("둥근모양 장풍");}
    }
}
