using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task2.V29.Lib
{
    

    // Реализация сервиса для задачи Вариант 29
    public class DataService : ISprint4Task2V29
    {
        // Метод вычисляет произведение чётных элементов массива
        public int Calculate(int[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0) // Чётное число
                {
                    product *= num;
                    hasEven = true;
                }
            }

            // Если чётных чисел нет — возвращаем 0
            return hasEven ? product : 0;
        }
    }
}
