using System.Text;

namespace Enums_in_C_
{
    internal class Program
    {

        [Flags]
        public enum Entypes
        {
            None = 0,
            CL = 1,
            SL = 2,
            NU = 4,
            SY = 8
        }
        static int RandomNumber(int num1, int num2)
        {

            var ob = new Random();
            int number = ob.Next(num1, num2);
            return number;

        }
        static char RandomChar()
        {


            int numbrt = RandomNumber(32, 126);
            char c = (char)numbrt;



            return c;

        }
        static StringBuilder RandomString(int lenght)
        {
            StringBuilder sb = new(lenght);

            for (int i = 0; i < lenght; i++)
            {
                char c = RandomChar();
                sb.Append(c);
            }



            return sb;

        }
        static int TakeTheChoice()
        {
            Entypes n = new();
            foreach (var i in Enum.GetNames(typeof(Entypes)))
            {
                Console.WriteLine($"{i}   y/n");
                string a = Console.ReadLine();
                if (a == "y" || a == "Y")
                {
                    n |= (Entypes)Enum.Parse(typeof(Entypes), i);
                }

            }
            return (int)n;
        }

        //The Project

        //================================================================================

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 
            Console.WriteLine("==============================================================================");
            Console.ReadKey();
        }
    
    
    
    
    
    }
}
