using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib
{

    public class DataService : ISprint4Task1V22
    {
        public int CalculateOddProduct(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) // Если число нечётное
                {
                    product *= num;
                    hasOdd = true;
                }
            }

            // Если нечётных чисел нет, возвращаем 0
            return hasOdd ? product : 0;
        }


    }
    
}

