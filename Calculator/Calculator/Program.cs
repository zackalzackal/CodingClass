




namespace Calcultator
{
    class Calculator
    {

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Multipy(int a, int b)
        {
            return a * b;
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }
    }
    class MainApp
    {
        public static void Main()
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            result = Calculator.Multipy(3, 4);
            Console.WriteLine(result);

            float result1 = Calculator.Divide(16, 3);
            Console.WriteLine(result1);
        }
    }

}
