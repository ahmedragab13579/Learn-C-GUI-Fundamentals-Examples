namespace TypeCasting_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt1 = 17;
            double myDouble1 = myInt1;       // Automatic casting: int to double

            Console.WriteLine(myInt1);      // Outputs 17
            Console.WriteLine(myDouble1);   // Outputs 17

            //==============================================================
            double myDouble2 = 17.58;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 17.58
            Console.WriteLine(myInt2);      // Outputs 17
            //=============================================================

            float MyFloat1 = myInt1;

            int myInt3 = (int)MyFloat1;

            //=============================================================
            myDouble2 = MyFloat1;
            //MyFloat1=myDouble; float to doubble make an error

            //=============================================================

            float MyFloat2 = 12;
            float MyFloat3 = 12.55f;
            //float MyFloat4 = 12.55; erorr with out f because it is a doubble
            //بيتعامل مع الكسور على انها doubble مشfloat

        }
    }
}
