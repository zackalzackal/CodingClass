namespace DerivedInterface
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat.");
            logger.WriteLog("{0} {1} = {2}", 1, 1, 2);
        }
    }
}
