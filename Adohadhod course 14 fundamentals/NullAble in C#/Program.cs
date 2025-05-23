namespace NullAble_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nullable<int> can be assigned any value
            //from - 2147483648 to 2147483647, or a null value.
            //Nullable<int> i = null;
            //  عباره عن حاويه لانواع التى لا تستطيع تحمل NONE  كقيمه
            int? i = null;
            int? j = 8;

            Nullable<int> n = null;
            Nullable<int> m = 8;
            Console.WriteLine(j.Value);
            Console.WriteLine(i.HasValue);
            int?[] x = new int ? [10];
            x[0] = 7;
            Console.WriteLine(x[0]);



            // int, float, double, bool, DateTime, char, struct انواع قيميه لا تحمل null
            // لانها تخذن فى stack لا يجوز ان تكون فارغه
            //string, object, class, array انواع تخزن بالعنوان

            int? a =77;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
            // Output:
            // a is 42
        }
    }
    }
