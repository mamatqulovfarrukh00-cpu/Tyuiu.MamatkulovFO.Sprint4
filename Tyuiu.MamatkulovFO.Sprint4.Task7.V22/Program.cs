using System;
using Tyuiu.MamatkulovFO.Sprint4.Task7.V22.Lib;

namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Вариант 22: Произведение нечётных элементов массива ===");
                Console.WriteLine("Введите 12 целых чисел от 2 до 9 (через Enter):");

                int[] array = new int[12];

                for (int i = 0; i < 12; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int number))
                        throw new FormatException("Введено не целое число.");

                    if (number < 2 || number > 9)
                        throw new ArgumentOutOfRangeException($"Число {number} должно быть в диапазоне [2, 9].");

                    array[i] = number;
                }

                var service = new DataService();
                int result = service.Calculate(array);

                Console.WriteLine($"\n✅ Массив: [{string.Join(", ", array)}]");
                Console.WriteLine($"✅ Произведение нечётных элементов: {result}");

                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Ошибка: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}