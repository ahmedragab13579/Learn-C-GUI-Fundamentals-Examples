namespace DateTime_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////assigns default value 01/01/0001 00:00:00
            
            DateTime dt1 = new();

            ////assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            ////assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            ////assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Local);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
//===================================================================================================

            DateTime utcTime = DateTime.UtcNow;
            DateTime Time = DateTime.Now;


            DateTime dt5 = new DateTime();

            dt5 = DateTime.Now;

            Console.WriteLine(dt5);                  
            Console.WriteLine(utcTime);             
            Console.WriteLine(Time);                 
            Console.WriteLine(utcTime.Kind);         



//===================================================================================================
            DateTime now = DateTime.Now;
            long binaryDate = now.ToBinary();
            Console.WriteLine(binaryDate);  //( طباعة القيمة الثنائية (عدد طويل).

            double oaDate = 45000.5; // يعني: 45000 يوم بعد 30 ديسمبر 1899 + نصف يوم = 12:00 ظهراً
            DateTime date = DateTime.FromOADate(oaDate);
            Console.WriteLine(date);  // الناتج: 2023-03-17 12:00:00


            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("====================================================================");
            
            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.WriteLine("====================================================================");
//===================================================================================================

            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

//===================================================================================================
            //invalid string date
            var str2 = "6/10/2023";
            DateTime dt7;

            var isValidDate2 = DateTime.TryParse(str2, out dt7);
            Console.WriteLine("====================================================================");

            var isValidDate3 = DateTime.Parse(str2);

            if (isValidDate2)
                Console.WriteLine(dt7);
            else
                Console.WriteLine($"{str2} is not a valid date string");





            Console.ReadKey();
        }
    }
}
