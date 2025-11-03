using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            // Проверка входных данных
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Строка не должна быть пустой.");

            if (value.Length != n * m)
                throw new ArgumentException($"Длина строки должна быть равна {n * m}.");

            int evenCount = 0;

            // Проходим по каждому символу строки
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    throw new ArgumentException($"Символ '{c}' не является цифрой.");

                int digit = c - '0'; // Преобразуем символ в число
                if (digit % 2 == 0)
                    evenCount++;
            }

            return evenCount;
        }
    }
}

