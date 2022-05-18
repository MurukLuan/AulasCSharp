using System;
using System.Globalization;

namespace AulasDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
           /* DateTime d2 = new DateTime(2022, 09, 15);
            DateTime d3 = new DateTime(2022, 09, 15, 22, 15, 55);
            DateTime d4 = new DateTime(2022, 09, 15, 22, 15, 55, 900);

            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.Parse("05/01/2008 8:30:52 PM", CultureInfo.InvariantCulture);
            DateTime d8 = DateTime.ParseExact("05/01/2008 20:30:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);*/

            TimeSpan time = new TimeSpan();
            TimeSpan time2 = new TimeSpan(0, 1, 30);
            TimeSpan time3 = TimeSpan.FromDays(2);
            TimeSpan time4 = TimeSpan.FromHours(20.5);
            TimeSpan time5 = TimeSpan.FromMinutes(1.5);
            TimeSpan time6 = TimeSpan.FromTicks(d1.Ticks);


            Console.WriteLine(time) ;
            Console.WriteLine(time);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(time6);

        }
    }
}
