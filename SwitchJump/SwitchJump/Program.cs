namespace SwitchJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string national = "한국";

            switch (national)
            {
                case "KOREA":
                    Console.WriteLine("서울");
                    break;
                case "JAPAN":
                    Console.WriteLine("도쿄");
                    break;
                default:
                    Console.WriteLine("서울");
                    break;

            }

            switch (national)
            {
                case "KOREA":
                case "한국":
                    Console.WriteLine("서울");
                    break;

                case "JAPAN":
                    Console.WriteLine("도쿄");
                    break;
                default:
                    Console.WriteLine("서울");
                    break;
            }                                                    
            national = "한국";
            switch (national)
            {
                case "KOREA":
                    Console.WriteLine("서울");
                    break;
                case "한국":
                    goto case "KOREA";
                case "JAPAN":
                    Console.WriteLine("도쿄");
                    break;

                default:
                    Console.WriteLine("서울");
                    break;
            }
        }
    }
}
