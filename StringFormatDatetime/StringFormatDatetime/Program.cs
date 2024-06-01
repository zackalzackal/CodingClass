﻿using System.Globalization;

namespace StringFormatDatetime
{'''''''''''''''
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            Console.WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm;;ss (ddd)}", dt);
            Console.WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

             CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt h:mm:ss (ddd)", ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            Console.WriteLine(dt.ToString(ciKo));
            CultureInfo ciEn = new CultureInfo("en-US");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:m:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            Console.WriteLine(dt.ToString(ciEn));

        }
    }
}
