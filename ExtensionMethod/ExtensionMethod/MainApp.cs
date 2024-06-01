using System;
using ExtensionMethod;
namespace ExtensionMethod
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : { 2.Power(10)}");
        }
    }
}
