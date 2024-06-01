namespace ToStringExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = 1234.4567;
            string str = "";

            str = d.ToString();
            Console.WriteLine($"{str} : {str.GetType().Name}");

            str = d.ToString("F");
            Console.WriteLine($"{str}");

            str = d.ToString("F4");
            Console.WriteLine($"{str}");

            str = d.ToString("F6");
            Console.WriteLine($"{str}");

            str = d.ToString("N");
            Console.WriteLine($"{str}");

            str = d.ToString("N3");
            Console.WriteLine($"{str}");

            str = d.ToString("0");
            Console.WriteLine($"{str}");

            str = d.ToString("0.00");
            Console.WriteLine($"{str}");

            str = d.ToString("0.0000");
            Console.WriteLine($"{str}");

            str = d.ToString("00000.0000000");
            Console.WriteLine($"{str}");
        }
    }
}
