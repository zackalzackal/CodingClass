using Indxer;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i<list.Length; i++)
                Console.WriteLine(list[i]);
            
        }
    }
}
