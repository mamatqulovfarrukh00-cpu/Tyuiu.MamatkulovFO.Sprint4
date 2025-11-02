using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task3.V8.Lib
{
   

// Реализация сервиса для задачи Вариант 3, V8
    public class DataService : ISprint4Task3V8
    {
        // Метод находит минимальный элемент в четвёртом столбце (индекс 3) двумерного массива
        public int Calculate(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0)
                throw new ArgumentException("Массив не может быть пустым или null.");

            // Проверяем, что массив имеет хотя бы 4 столбца
            if (array.GetLength(1) < 4)
                throw new ArgumentException("Массив должен содержать как минимум 4 столбца.");

            int min = array[0, 3]; // Начальное значение — первый элемент 4-го столбца

            for (int i = 1; i < array.GetLength(0); i++) // Перебираем строки
            {
                if (array[i, 3] < min)
                    min = array[i, 3];
            }

            return min;
        }
    }
}

