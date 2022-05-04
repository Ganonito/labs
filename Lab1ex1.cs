using System;
namespace Lab1ex1
{
    public class Program
    {
        static public double Example(int N)
        {

            double m = N / 60;

            Console.WriteLine("\nХвилин = " + m.ToString());
            return m;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введiть кiлькiсть секунд: ");
            string S1 = Console.ReadLine();
            int N = int.Parse(S1);
            Example(N);
            Console.ReadLine();

        }
    }
}
