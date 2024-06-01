namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const long FACTORIAL = 10;
            Console.Write("NonRecursiveFactorial : ");
            Console.WriteLine(NonRecursiveFactorial(FACTORIAL));

            Console.Write("RecursiveFactorial : ");
            Console.WriteLine(RecursiveFactorial(FACTORIAL));
        }

        static long NonRecursiveFactorial(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= 1;
            }
            return factorial;
        }
        static long RecursiveFactorial(long n)
        {
            if (n == 0){
                return 1;
            }
            return RecursiveFactorial(n - 1)* n;
                
        }
    }
}

