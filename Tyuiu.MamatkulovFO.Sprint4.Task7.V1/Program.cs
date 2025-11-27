using System;
using Tyuiu.MamatkulovFO.Sprint4.Task7.V22.Lib;

namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Преобразование строки в матрицу 3x3 и подсчёт чётных цифр ===");
                Console.Write("Введите строку из 9 однозначных цифр (например, 135792468): ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    throw new ArgumentException("Строка не может быть пустой.");

                var service = new DataService();
                int evenCount = service.Calculate(3, 3, input);

                Console.WriteLine($"\n✅ Количество чётных цифр: {evenCount}");

                // Вывод матрицы 3x3
                Console.WriteLine("\n✅ Матрица 3x3:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(input[i * 3 + j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}