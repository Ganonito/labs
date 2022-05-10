using System;
namespace lab2ex3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.WriteLine());
            var a = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Масив:\n" + string.Join(", ", a));

            var maxIndex = 100;
            var maxValue = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > maxValue)
                {
                    maxValue = a[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Максимальний елемент масиву: {maxValue}");
            Console.ReadKey();
        }
    }
