using System;
using System.Linq;
namespace Lab3ex1A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = (Console.ReadLine());
            char[] ch = str.ToCharArray();
            var count = ch.Where((n) => n >= '0' && n <= '9').Count();
            Console.WriteLine("К-сть цифр у текстi: " + count);
            Console.ReadKey();
        }
    }
}
