using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib
{
    
        public class DataService : ISprint4Task0V23
        {
            /// <summary>
            /// Вычисляет произведение всех нечётных элементов в массиве.
            /// Если нечётных элементов нет — возвращает 0.
            /// Если массив null — выбрасывает исключение.
            /// </summary>
            /// <param name="array">Массив целых чисел</param>
            /// <returns>Произведение нечётных чисел или 0</returns>
            public int GetMultOddArrEl(int[] array)
            {
                if (array == null)
                    throw new ArgumentNullException(nameof(array));

                int product = 1;
                bool hasOdd = false;

                foreach (int num in array)
                {
                    if (num % 2 != 0) // нечётное число
                    {
                        product *= num;
                        hasOdd = true;
                    }
                }

                return hasOdd ? product : 0;
            }
        }
    
}

