using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
        {
            // Проверяем, что массив существует и содержит ровно 12 элементов
            if (array == null || array.Length != 12)
                throw new ArgumentException("Массив должен содержать ровно 12 элементов.");

            // Проверяем, что все элементы находятся в допустимом диапазоне [2, 9]
            foreach (int num in array)
            {
                if (num < 2 || num > 9)
                    throw new ArgumentException($"Элемент {num} выходит за пределы диапазона [2, 9].");
            }

            int product = 1;        // Начальное значение произведения
            bool hasOdd = false;    // Флаг: найдено ли хотя бы одно нечётное число

            // Проходим по всем элементам массива
            foreach (int num in array)
            {
                // Если число нечётное
                if (num % 2 != 0)
                {
                    product *= num; // Умножаем на произведение
                    hasOdd = true;  // Отмечаем, что есть нечётное число
                }
            }

            // Если нечётных чисел не было — возвращаем 0
            if (!hasOdd)
                return 0;

            return product;
        }
    }
}
    

