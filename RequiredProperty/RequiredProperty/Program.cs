namespace RequiredProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo() { Name = "정섭", Birthday = new DateTime(2009, 08, 12) };

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}",birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
