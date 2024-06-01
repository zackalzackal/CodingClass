using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethod()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethod()");
        }

        public abstract void AbstractMethodA();
    }
}
