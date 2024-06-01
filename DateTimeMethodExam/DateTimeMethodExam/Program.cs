using System.Data;

namespace DateTimeMethodExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            TimeSpan duration = new TimeSpan(36, 0, 0, 0);
            Console.WriteLine("AddTimeSpan : {0}", now.Add(duration));
            Console.WriteLine("AddDays : {0}",now.AddDays(36));
            Console.WriteLine("\"==============================");
            double[] hours = { 0.08333, 0.16667, 0.25, 0.333333, 0.5, 1, 2, 29, 30, 31 };
            foreach (double hour in hours)
            {
                Console.WriteLine("{0} + {1} hour(s) = {2}", now, hour, now.AddHours(hour));
            }
            Console.WriteLine("==============================");
            double[] minutes = { .01667, .08333, .16667, .25, .33333, .5, .66667, 1, 2, 15, 30, 17, 45, 60, 180.60 * 24 };
            foreach (double minute in minutes)
                    Console.WriteLine("{0} + {1} minute(s) = {2}",now, minute, now.AddMinutes(minute));
            Console.WriteLine("==============================");
            DateTime utcNow = DateTime.UtcNow;
            DateTime currNow = DateTime.Now;
            DateTime copyNow = utcNow;

            bool result = utcNow.Equals(currNow);
            Console.WriteLine("The result of comparing DateTime object one and two is: {0}.", result);
            result = utcNow.Equals(copyNow);
            Console.WriteLine("The result of comparing DateTime object one and three is: {0}.", result);





        }
    }
}
