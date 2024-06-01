namespace Multiline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string multiline = """
                별 하나에 추억과
                별 하나에 사랑과
                별 하나에 쓸쓸함과
                별 하나에 동경과
                별 하나에 시와
                별 하나에 어머니, 어머니
                """;

            Console.WriteLine(multiline);
            Console.WriteLine();

            Console.WriteLine("별 하나에 추억과\n별 하나에 사랑과\n별 하나에 쓸쓸함과\n별 하나에 동경과\n별 하나에 시와\n별 하나에 어머니,어머니");

            string multiline2 = "별 하나에 추억과"
             + "\n" + "별 하나에 사랑과" + "\n" + "별 하나에 쓸쓸함과"
             + "\n" + "별 하나에 동경과" + "\n" + "별 하나에 시와"
             + "\n" + "별 하나에 어머니, 어머니";

            Console.WriteLine();
            Console.WriteLine(multiline2);
        }
    }
}
