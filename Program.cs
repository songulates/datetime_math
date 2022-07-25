using System;

namespace proje_odev // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine(DateTime.Now); 
           Console.WriteLine(DateTime.Now.Date);
           Console.WriteLine(DateTime.Now.Day);
           Console.WriteLine(DateTime.Now.Month);
           Console.WriteLine(DateTime.Now.Year);
           Console.WriteLine(DateTime.Now.Hour);
           Console.WriteLine(DateTime.Now.Minute);
           Console.WriteLine(DateTime.Now.Second);
           Console.WriteLine(DateTime.Now.DayOfWeek);
           Console.WriteLine(DateTime.Now.DayOfYear);
           Console.WriteLine(DateTime.Now.ToLongDateString());
           Console.WriteLine(DateTime.Now.ToShortDateString());
           Console.WriteLine(DateTime.Now.ToLongTimeString());
           Console.WriteLine(DateTime.Now.ToShortTimeString());
           Console.WriteLine(DateTime.Now.AddDays(2));
           Console.WriteLine(DateTime.Now.AddHours(2));
           Console.WriteLine(DateTime.Now.AddSeconds(2));
           Console.WriteLine(DateTime.Now.AddMinutes(2));
           Console.WriteLine(DateTime.Now.AddMonths(2));
           Console.WriteLine(DateTime.Now.AddYears(2));
           Console.WriteLine(DateTime.Now.ToString("dd")); //format
           Console.WriteLine(DateTime.Now.ToString("ddd")); //format
           Console.WriteLine(DateTime.Now.ToString("dddd")); //format
           Console.WriteLine(DateTime.Now.ToString("M")); //format
           Console.WriteLine(DateTime.Now.ToString("MM")); //format
           Console.WriteLine(DateTime.Now.ToString("MMM")); //format
           Console.WriteLine(DateTime.Now.ToString("yy")); //format
           Console.WriteLine(DateTime.Now.ToString("yyyy")); //format
           Console.WriteLine(Math.Abs(-25)); //Math
           Console.WriteLine(Math.Sin(30)); //Math
           Console.WriteLine(Math.Ceiling(22.3)); //Math
           Console.WriteLine(Math.Round(22.3)); //Math
           Console.WriteLine(Math.Round(22.7)); //Math
           Console.WriteLine(Math.Floor(22.7)); //Math
            Console.WriteLine(Math.Max(2,63)); //Math
            Console.WriteLine(Math.Min(2,63)); //Math
             Console.WriteLine(Math.Pow(3,4)); //Math üs 3 üs 4
             Console.WriteLine(Math.Sqrt(9)); //
             Console.WriteLine(Math.Log(10)); 
             Console.WriteLine(Math.Exp(3)); //Math e üzeri 3
             Console.WriteLine(Math.Log10(10)); 
        }

    }
}
