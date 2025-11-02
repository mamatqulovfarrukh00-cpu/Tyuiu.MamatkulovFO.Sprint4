using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib
{

    public class DataService : ISprint4Task1V22
    {
        public int CalculateOddProduct(int[] array)
        {
            // Выбираем уникальные нечётные числа
            var odds = array.Where(x => x % 2 == 1).Distinct().ToArray();

            // Если нет нечётных — результат 0
            if (odds.Length == 0) return 0;

            // Считаем произведение
            int result = 1;
            foreach (int num in odds)
                result *= num;

            return result; // Для {8,5,4,4,3,9,...} → 5*3*9 = 135
        }

        /// <summary>
        /// Перегрузка метода (требуется интерфейсом, но не используется).
        /// Просто вызывает основной метод.
        /// </summary>
        public int CalculateOddProduct(int[] array, bool v)
        {
            return CalculateOddProduct(array);
        }
    }
}
    


