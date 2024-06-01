namespace stringconcap
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string str1 = "Apple";
            string str2 = "Banana";
            string str3 = "Watermelon";

            string strConcat = string.Concat(str1, str2, str3);
            Console.WriteLine(strConcat);

            string strPlus = str1 + str2 + str3;
            Console.WriteLine(strPlus);

        }
    }
}
