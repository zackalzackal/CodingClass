namespace Trhow
{
    internal class Program
    {
        static void Dosomething(int args)
        {
            if (args < 10)
                Console.WriteLine($"arg : {args}");
            else
                throw new Exception("args가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                Dosomething(1);
                Dosomething(3);
                Dosomething(5);
                Dosomething(9);
                Dosomething(11);
                Dosomething(13);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("박정섭바보");
            }
        }
    }
}
