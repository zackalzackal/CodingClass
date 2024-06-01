namespace Stringcompare
{
    internal class MainApp
    {
        public static void Testpost(int[] array)
        {
            array[0] = 1000;
        }

        public static void Testpost(string name)
        {
            name = "TEST";
            Console.WriteLine(" IN Testpost name : {0}", name);

        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40 };
            Console.WriteLine(arr[0]);

            Testpost(arr);
            Console.WriteLine(arr[0]);

            String name = "LUNA JIN";
            Console.WriteLine(name);
            Testpost(name);
            Console.WriteLine(name);
        }   
    }
}
