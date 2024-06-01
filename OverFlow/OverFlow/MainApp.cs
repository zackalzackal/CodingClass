using System.Formats.Asn1;

namespace OverFlow
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;
            Console.WriteLine("더하실 수를 입력해주세요 ==>");
            uint b = UInt32.Parse(Console.ReadLine());
            if (a+b < b) 
            {
                Console.WriteLine("다시 입력해주세요");
                Console.WriteLine("a값 ==> {0}", a + b);
            }
        }
    }
}
