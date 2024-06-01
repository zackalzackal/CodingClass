namespace RecordComp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Charlie", Amount = 100 };

            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}");

            Rtransaction tr1 = new Rtransaction { From = "Alice", To = "Bob", Amount = 100 };
            Rtransaction tr2 = tr1 with { };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");

            
        }
    }
}
