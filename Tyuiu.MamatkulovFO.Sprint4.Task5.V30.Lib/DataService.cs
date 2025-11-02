using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int sumPositive = 0;

            // Massiv o'lchamini aniqlash (5x5 deb taxmin qilinadi, lekin umumiy usul)
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sumPositive += matrix[i, j];
                    }
                }
            }

            return sumPositive;
        }
    }
}
