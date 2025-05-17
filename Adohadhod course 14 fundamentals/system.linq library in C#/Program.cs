
using System;
using System.Linq;
namespace system.linq_library_in_C_
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    };
    internal class Program
    {
        static void Main(string[] args)
        {

            // Note that we used System.Linq above.

            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in arr
              Console.WriteLine("Largest Element: " + numbers.Max());

            //where()
            IEnumerable<int> numbers2 = numbers.Where(n => n % 2 == 0);//n=> lambda function
            //IEnumerable--> تسلسل من نوع بيانات محدد يمكن التكرار عليه
            //select()
            IEnumerable<int> numbers3 = numbers.Select(n => n + 2);//n=> lambda function make a operation
         
            var people = new List<Person>
{
              new Person { Name = "Ali", Age = 30 },
              new Person { Name = "Sara", Age = 25 },
              new Person { Name = "Mohamed", Age = 28 }
}; 

            var names = people.Select(p => p.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);  // يطبع: Ali, Sara, Mohamed
            }
            //OrderBy()
            IEnumerable<int> numbers4 = numbers.OrderBy(n=>n);// تصاعدى
            //OrderByDescending()
            IEnumerable<int> numbers5 = numbers.OrderByDescending(n => n);// تنازلى
            //order()
            //IEnumerable<int> numbers6 = numbers.Order();//
            //sum()
            int sum = numbers.Sum();
            Console.WriteLine (sum);
            //Count()
            int Count = numbers.Count();
            Console.WriteLine (Count);
            Console.ReadKey();
             //Average()
            double Average = numbers.Average();
            Console.WriteLine (Average);
            Console.ReadKey();



        }
    }
}
