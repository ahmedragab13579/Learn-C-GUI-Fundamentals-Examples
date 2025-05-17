using System.Numerics;

namespace Dynamic_Word_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dynamic use to 
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

 // 1.وقت الترجمة(Compile Time):
 //تعريف: هو الوقت الذي يقوم فيه المترجم(compiler) بتحويل الشيفرة المصدرية(source code) إلى كود يمكن تشغيله(مثل IL في C# أو الشيفرة الثابتة).

 //أين يحدث؟ يحدث قبل تشغيل البرنامج.

 //العمليات التي تحدث:

 //التحقق من الأخطاء النحوية(syntax errors).

 //التحقق من صحة الأنواع(type checking) — مثل التأكد من أن المتغيرات تتوافق مع الأنواع المتوقعة.

 //تحديد تخصيص الذاكرة


//            2.وقت التشغيل(Runtime):
//تعريف: هو الوقت الذي يتم فيه تشغيل البرنامج، أي عندما يتم تنفيذ الكود بعد ترجمته.

//أين يحدث؟ يحدث أثناء تشغيل التطبيق على جهاز الكمبيوتر.

//العمليات التي تحدث:

//            تنفيذ العمليات الفعلية(مثل الحسابات، التفاعل مع الملفات، الاتصال بالشبكة).

//التعامل مع الأخطاء التي قد تحدث أثناء التنفيذ(مثل محاولات الوصول إلى ملف مفقود، أو محاولة القسمة على صفر).





            Console.ReadKey();
        }
    }
}
