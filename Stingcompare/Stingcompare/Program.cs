using System.Security.Principal;

namespace Stingcompare
{
    internal class Mainapp
    {
        static void Main(string[] args)
        {
            char c1 = 'a';
            char c2 = 'A';
            char c3 = 'a';
            char c4 = 'b';
            Console.WriteLine(c1.CompareTo(c2));
            //console.WirteLine(string.compare(c1,c2));
            Console.WriteLine(c1.CompareTo(c3));
            Console.WriteLine(c1.CompareTo(c4));

            string str1 = "abc";
            string str2 = "abc";
            string str3 = "abc";
            string str4 = "abc";
            Console.WriteLine("compare To : {0}", str1.CompareTo(str2));
            Console.WriteLine("compare To : {0}", str1.CompareTo(str3));
            Console.WriteLine("compare To : {0}", str1.CompareTo(str4));
            Console.WriteLine("compare : {0}", string.Compare(str1, str2));
            Console.WriteLine("compare : {0}", string.Compare(str1, str3));
            Console.WriteLine("compare : {0}", string.Compare(str1, str4));

            Console.WriteLine("string.Compare(\"A\", \"B\"): " + string.Compare("A", "B"));

        }
    }
}
