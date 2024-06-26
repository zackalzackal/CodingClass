using System.Globalization;

namespace ExceoptionFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0~10");
            String input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);

                if (num < 0 || num > 10)
                    throw new Filterableexceoption() { ErrorNO = num };
                else
                    Console.WriteLine($"Output : {num}");
            }
            catch (Filterableexceoption e) when (e.ErrorNO < 0)
            {
                Console.WriteLine("Negative input is not allowed");
            }
            catch(Filterableexceoption e) when (e.ErrorNO > 10)
            {
                Console.WriteLine("Too big number is not allowed.");
            }
        }
    }
}
