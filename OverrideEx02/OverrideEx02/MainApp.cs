namespace OverrideEx02
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Ryu ryu = new Ryu();
            ryu.forward();
            ryu.energy();
            ryu.kick();

            Ken ken = new Ken();
            ken.forward();
            ken.energy();
            ken.kick();

            Guile guile = new Guile();
            guile.forward();
            guile.energy();
            guile.kick();
        }
    }
}
