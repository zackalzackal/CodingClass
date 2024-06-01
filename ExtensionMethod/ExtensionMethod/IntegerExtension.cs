using System;
namespace ExtensionMethod
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponet)
        {
            int result = myInt;
            for (int i = 1; i < exponet; i++)
                result = result * myInt;

            return result;
        }
    }
}
