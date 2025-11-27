using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MamatkulovFO.Sprint4.Task7.V22.Lib;

namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectEvenCount()
        {
            // Подготовка
            var service = new DataService();
            string input = "135792468"; // Чётные: 2, 4, 6, 8 → 4 шт.

            // Действие
            int result = service.Calculate(3, 3, input);

            // Проверка
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_InputTooShort_ThrowsException()
        {
            var service = new DataService();
            service.Calculate(3, 3, "12345"); // Только 5 символов
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_InputContainsNonDigit_ThrowsException()
        {
            var service = new DataService();
            service.Calculate(3, 3, "12a456789"); // 'a' — не цифра
        }

        [TestMethod]
        public void Calculate_AllOdd_ReturnsZero()
        {
            var service = new DataService();
            string input = "135791357"; // Все нечётные
            int result = service.Calculate(3, 3, input);
            Assert.AreEqual(0, result);
        }

        public static void Main()
        {
            try
            {
                Console.WriteLine("=== Преобразование строки в матрицу 3x3 и подсчёт чётных цифр ===");
                Console.Write("Введите строку из 9 однозначных цифр (например, 135792468): ");
                string input = Console.ReadLine()?.Trim();

                var service = new DataService();
                int evenCount = service.Calculate(3, 3, input);

                Console.WriteLine($"\nКоличество чётных цифр: {evenCount}");

                // Дополнительно: вывод матрицы 3x3
                Console.WriteLine("\nМатрица 3x3:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(input[i * 3 + j] + " ");
                    }
                    Console.WriteLine(); // Перевод строки
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
