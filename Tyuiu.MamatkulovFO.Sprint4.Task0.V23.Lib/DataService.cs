using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task0.V23.Lib
{
        public class DataService : ISprint4Task0V23
        {
        public int GetMultOddArrEl(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int product = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    product *= num;
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0;
        }
    }
    
}
