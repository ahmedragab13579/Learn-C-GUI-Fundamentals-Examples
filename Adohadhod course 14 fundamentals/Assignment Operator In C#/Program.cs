namespace Assignment_Operator_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // دول الحاجه الجديده بس 
            int x = 100;

            // use in [int] only
            Console.WriteLine(x);
            x >>= 5;//هذا يعادل قسمة العدد على 2^5 = 32 (في حالة الأعداد الموجبة)
            Console.WriteLine(x);
            x <<= 5;//هذا يعادل ضرب العدد في 2^5 = 32
            Console.WriteLine(x);
            //x => x * x; like lambda function




            //            | العملية | مع السالب | النتيجة  |
            //| ------------------- | ----------- | ----------------------------------- |
            //| `x << n`            | ✅ شغال |     كأنه ضرب في 2ⁿ، يحتفظ بالسالب       |
            //| `x >> n` (signed)   |  ✅ شغال |  كأنه قسمة على 2ⁿ، يحتفظ بالسالب       |
            //| `x >> n` (unsigned) | ❌ غير منطقي | يدخّل أصفار من الشمال، يكسر الإشارة  |





            //🧠 ما هو Two's Complement؟

        }
    }
}
