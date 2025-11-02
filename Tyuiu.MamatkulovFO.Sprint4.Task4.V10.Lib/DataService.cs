using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task4.V10.Lib
{
    public class DataService : ISprint4Task4V10
    {
        // Метод заменяет все нечётные элементы массива на 0
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                return matrix; // или throw new ArgumentNullException();

            // Создаём копию массива, чтобы не менять исходный
            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (result[i, j] % 2 != 0) // Если элемент нечётный
                        result[i, j] = 0;      // Заменяем на 0
                }
            }

            return result;
        }
    }
}
