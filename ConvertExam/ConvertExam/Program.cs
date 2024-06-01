namespace ConvertExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫 번쨰 숫자를 입력하세요 : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번쨰 숫자를 입력하세요 : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
    }
}
