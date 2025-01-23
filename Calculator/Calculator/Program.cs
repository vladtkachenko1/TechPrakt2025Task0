using System;
using System.Data;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Консольний калькулятор");
        Console.WriteLine("Введіть вираз  і натисніть Enter. Введіть 'exit' для виходу.");

        while (true)
        {
            Console.Write("Введіть вираз: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Порожній ввід. Спробуйте ще раз.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Вихід з програми.");
                break;
            }

            try
            {
                // Використання DataTable для обчислення виразу
                var result = new DataTable().Compute(input, null);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Некоректний вираз. Спробуйте ще раз.");
            }

            Console.WriteLine();
        }
    }
}
