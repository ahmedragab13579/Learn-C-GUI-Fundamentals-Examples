using System;
using System.Text.RegularExpressions;

namespace Strings_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S1 = "Ahmed Ragab Abdelrahim";
            string S2 = "Ahmed Ragab Abd   elra    him      ";

            Console.WriteLine(S1.Length);//Property Not A Method

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));


            string[] NamesList = S2.Split(',');
            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Ali-Hamed  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            //============================================================================
            Console.WriteLine(S1.Length);
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1.Replace('a', 'b'));
            NamesList = S1.Split(' ');
            Console.WriteLine(NamesList[0]);
            Console.WriteLine(S1.Insert(S1.Length,"Abdelhamid"));
            Console.WriteLine(S1.IndexOf('m'));
            Console.WriteLine(S1.LastIndexOf('m'));
            Console.WriteLine(S1.Contains('m'));
            Console.WriteLine(S1.Contains('m'));
            //=========================================================================
            Console.WriteLine(S2.Trim());
            Console.WriteLine(S2.TrimEnd());
            Console.WriteLine(S2.TrimStart());

            //=========================================================================
                // أزل الفراغات الزائدة داخل النص
                string result1 = Regex.Replace(S2, @"\s+", " ");
                string result2 = S2.Replace(" ","");
                string result3 = Regex.Replace(S2, @"\s+", "");

            Console.WriteLine(result1); 
            Console.WriteLine(result2);
            //=========================================================================
            string fullName = $"Mr. {NamesList[0]} {NamesList[1]}";
            Console.WriteLine(fullName); 
        }
    }
}
