
using System;
using System.Collections;
using static System.Console;
namespace Hahtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("Data1", new HongsClass() { Name = "홍진현1", intCount = 1 });
            hashtable.Add("Data2", new HongsClass() { Name = "홍진현2", intCount = 2 });

            if (hashtable.ContainsKey("Data1").Equals(true))
            {
                HongsClass temp = hashtable["Data1"] as HongsClass;
                Console.WriteLine(temp.Name);
            }

            foreach (string NowKey in hashtable.Keys)
            {
                HongsClass temp = hashtable[NowKey] as HongsClass;
                Console.WriteLine(temp.Name);
            
            }
        }
    }
}
