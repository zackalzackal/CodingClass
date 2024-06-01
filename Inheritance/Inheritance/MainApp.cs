using System.Runtime.InteropServices.Marshalling;

namespace Inheritance
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            //Derived b = new Derived("b");

           
            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
           
        }
    }
}
