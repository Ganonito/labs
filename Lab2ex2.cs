class Program
{
    static void Main(string[] args)
    {
        float x = 1;
        int max = 6;
        float dx = 0.2f;
        while (x <= max)
        {
            float y = (float)Math.Log10(x);

            Console.WriteLine("\n x = " + x);
            Console.WriteLine("Функцiя y = " + y);
            x += dx;

        }
    }
}
