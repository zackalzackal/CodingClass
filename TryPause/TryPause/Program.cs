namespace TryPause
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1234";
            string s2 = "1234.65";
            string s3 = null;
            string s4 = "123456789123456789123456789123456789123456789";

            int result;
            bool success;

            success = Int32.TryParse(s1, out result);
            Console.WriteLine("s1 : {0} : {1}", success, result);
            success = Int32.TryParse(s2, out result);
            Console.WriteLine("s2 : {0} : {1}", success, result);

            success = Int32.TryParse(s3, out result);
            Console.WriteLine("s3 : {0} : {1}", success, result);

            success = Int32.TryParse(s4, out result);
            Console.WriteLine("s4 : {0} : {1}", success, result);
        }
    }
}
