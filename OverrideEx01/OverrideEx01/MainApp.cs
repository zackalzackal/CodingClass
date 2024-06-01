namespace OverrideEx01
{
    internal class MainApp
    { 

        static void Main(string[] args)
        {
            Monster monster1 = new Monster();
            Orc monster2 = new Orc();
            Elf monster3 = new Elf();
            Wolf monster4 = new Wolf();

            monster1.hit();
            monster2.hit();
            monster3.hit();
            monster4.hit();
            Console.WriteLine("====================");
            Monster monster5 = new Orc();
            Monster monster6 = new Elf();
            Monster monster7 = new Wolf();
            monster5.hit();
            monster6.hit();
            monster7.hit();


        }
    }
}
