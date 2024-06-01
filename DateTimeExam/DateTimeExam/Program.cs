namespace DateTimeExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime toDay = DateTime.Today;
            Console.WriteLine(toDay);
            Console.WriteLine("toDay : {0}", toDay.ToString());
            Console.WriteLine("Date : {0}", toDay.Date);

            Console.WriteLine("===================================");

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("now : {0}", now.ToString());
            Console.WriteLine($"Date : {now.Date}");
            Console.WriteLine($"Day : {now.DayOfWeek}");
            Console.WriteLine($"DayOfWeek : {now.DayOfWeek}");
            Console.WriteLine($"DayOfYear : {now.DayOfYear}");
            Console.WriteLine($"Hour : {now.Hour}");
            Console.WriteLine($"Kind : {now.Kind}");
            Console.WriteLine($"Microsecond : {now.Microsecond}");
            Console.WriteLine($"Millisecond : {now.Millisecond}");
            Console.WriteLine($"Minute : {now.Minute}");
            Console.WriteLine($"Nanosecond : {now.Nanosecond}");
            Console.WriteLine($"Second : {now.Second}");
            Console.WriteLine($"Ticks : {now.Ticks}");
            Console.WriteLine($"TimeOfDay : {now.TimeOfDay}");
            Console.WriteLine($"Year : {now.Year}");

        }
    }
}
