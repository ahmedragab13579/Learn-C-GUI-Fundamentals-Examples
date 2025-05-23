using System;

namespace Ticks_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////number of 100-nanosecond intervals that have elapsed النانو ثانيه 
            ////since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 
            // Ticts هى الفمتو ثانيه هى وحده طول ليست تاريخ

            DateTime dt1 = new DateTime(2000,8,10);
            DateTime dt2 = new DateTime(2001, 8, 10);
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks
            long dt3 = dt2.Ticks - dt1.Ticks;
            TimeSpan dt4 = dt2 - dt1;
            TimeSpan dt6 = dt2.Subtract(dt1);
            //DateTime [dt4 = dt2 - dt1]  خطا 
            DateTime dt5 = dt1 + TimeSpan.FromHours(2); // ده صحيح

            //DateTime - DateTime -->TimeSpan
            //DateTime + TimeSpan -->DateTime
            //DateTime - TimeSpan -->DateTime






            Console.WriteLine(dt3);// طرح اطول الناتج طول
            Console.WriteLine(dt4);// طرح تواريخ الناتج تاريخ
            Console.WriteLine(dt5);// طباعه التاريخ بعد اضافه  ساعتين





            DateTime dt = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);// يتعمل مع التجاوزات يعنى لو عديت ال24 ساعه هيقربها ليوم 
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);



            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True



        }
    }
}
