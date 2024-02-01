using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть перше число:");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.WriteLine("Введіть друге число:");
            if (double.TryParse(Console.ReadLine(), out double number2))
            {
                double sum = number1 + number2;
                Console.WriteLine($"Сума: {sum}");
            }
        }
    }
}
