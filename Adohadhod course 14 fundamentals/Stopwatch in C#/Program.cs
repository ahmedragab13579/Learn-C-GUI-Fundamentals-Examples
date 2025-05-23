using System.Diagnostics;

namespace StopWatch_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch(); // إنشاء كائن Stopwatch
            sw.Start(); // بدء التوقيت

            // كود تريد قياس الوقت الذي يستغرقه
            for (int i = 0; i < 1000000; i++)
            {
                // عملية وهمية
            }

            sw.Stop(); // إيقاف التوقيت

            Console.WriteLine("الوقت المستغرق بالمللي ثانية: " + sw.ElapsedMilliseconds);
            Console.WriteLine("الوقت المستغرق بالـ Ticks: " + sw.ElapsedTicks);
        }
    }
}
