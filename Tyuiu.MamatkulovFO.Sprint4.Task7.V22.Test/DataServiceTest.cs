using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;

namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectProduct()
        {
            // Подготовка
            var service = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 3, 4, 4, 9, 2 }; // Из условия: 8,5,4,4,3,9,9,3,4,4,9,2

            // Действие
            int result = service.Calculate(array);

            // Проверка: нечётные: 5, 3, 9, 9, 3, 9 → произведение = 5 * 3 * 9 * 9 * 3 * 9 = 32805
            Assert.AreEqual(32805, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_ArrayNot12Elements_ThrowsException()
        {
            var service = new DataService();
            int[] array = { 8, 5 }; // Только 2 элемента
            service.Calculate(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_ElementOutOfRange_ThrowsException()
        {
            var service = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 3, 4, 4, 9, 1 }; // 1 < 2 — выходит за диапазон
            service.Calculate(array);
        }

        [TestMethod]
        public void Calculate_NoOddNumbers_ReturnsZero()
        {
            var service = new DataService();
            int[] array = { 8, 4, 4, 4, 6, 8, 2, 4, 6, 8, 2, 4 }; // Все чётные
            int result = service.Calculate(array);
            Assert.AreEqual(0, result);
        }

        public static void Main()
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

                Console.WriteLine("\nДля завершения нажмите любую клавишу...");
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