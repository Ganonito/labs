using System;
namespace lab2ex1
{
    public class Program
    {
        public static string s(String chuclo)
        {
            switch (chuclo)
            {
                case "1":
                    return "Бунiховський Микола";
                
                case "2":
                    return "Дарiйчук Роман";

                case "3":
                    return "Муха Всеволод";

                case "4":
                    return "Кравчук Андрiй";

                case "5":
                    return "Лазарєв Микита";

                case "6":
                    return "Лук`янюк Владислав";

                case "7":
                    return "Міхеeв Iгор";

                case "8":
                    return "Педурару Олександр";

                case "9":
                    return "Подолян Вадим";

                case "10":
                    return "Понич Олексiй";

                default:
                    return "Введiть число вiд 1 до 10!";
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------\n" +
                                  "Почати введення номеру - 1\n" +
                                  "Вийти - 2");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 2)
                        break;
                    else if (choice != 1)
                        continue;
                    Console.WriteLine("------------------------------------------");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("*****\nВводити можна тiльки числа!\n*****");
                    continue;
                }

                Console.Write("Введiть номер: ");
                Console.WriteLine(s(Console.ReadLine()));
            }
        }
    }
}
