using System.Drawing;

namespace Convert_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt1 = 20;
            double myDouble1 = 7.25;
            bool myBool1 = true;
            //==============================================================================
            Console.WriteLine(Convert.ToString(myInt1));
            Console.WriteLine(Convert.ToString(myDouble1));
            Console.WriteLine(Convert.ToString(myBool1));
            Console.WriteLine("==============================================================================");
            Console.WriteLine(Convert.ToDouble(myInt1));
            Console.WriteLine(Convert.ToDouble(myDouble1));
            Console.WriteLine(Convert.ToDouble(myBool1));
            Console.WriteLine("==============================================================================");
            Console.WriteLine(Convert.ToBoolean(myInt1));
            Console.WriteLine(Convert.ToBoolean(myDouble1));
            Console.WriteLine(Convert.ToBoolean(myBool1));
            Console.WriteLine("==============================================================================");
            Console.WriteLine(Convert.ToInt32(myInt1));
            Console.WriteLine(myInt1.GetType());
            Console.WriteLine(Convert.ToInt32(myDouble1));
            Console.WriteLine(Convert.ToInt32(myBool1));
            Console.WriteLine("==============================================================================");
            Console.WriteLine(Convert.ToInt16(myInt1));
            Console.WriteLine(myInt1.GetType());//not change 
            Console.WriteLine(Convert.ToInt16(myDouble1));
            Console.WriteLine(Convert.ToInt16(myBool1));
            Console.WriteLine("==============================================================================");
            Console.WriteLine(Convert.ToInt64(myInt1));
            Console.WriteLine(myInt1.GetType());//not change 
            Console.WriteLine(Convert.ToInt64(myDouble1));
            Console.WriteLine(Convert.ToInt64(myBool1));


            // change the type temprary if you want to
            // change the type you must make another variable


          
        }
    }
}
