using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            // Проверка: строка не должна быть пустой
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Строка не должна быть пустой.");

            // Проверка: длина строки должна быть равна n * m (в нашем случае 3*3=9)
            if (value.Length != n * m)
                throw new ArgumentException($"Длина строки должна быть равна {n * m}.");

            int evenCount = 0;

            // Проходим по каждому символу строки
            foreach (char c in value)
            {
                // Проверяем, является ли символ цифрой
                if (!char.IsDigit(c))
                    throw new ArgumentException($"Символ '{c}' не является цифрой.");

                // Преобразуем символ в число
                int digit = c - '0';

                // Проверяем, чётное ли число
                if (digit % 2 == 0)
                    evenCount++;
            }

            return evenCount;
        }
    }
}