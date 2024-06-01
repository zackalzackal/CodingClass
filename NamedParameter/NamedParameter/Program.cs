namespace NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(phone: "010-123-1234", name: "박찬호");
        }
    }
}
