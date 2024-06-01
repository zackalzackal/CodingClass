namespace StringFormatBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            Console.WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}