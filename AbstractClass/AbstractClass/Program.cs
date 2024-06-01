namespace AbstractClass
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
           Derived obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
