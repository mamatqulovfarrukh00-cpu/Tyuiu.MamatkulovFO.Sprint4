using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib
{

    public class DataService : ISprint4Task1V22
    {
        public int CalculateOddProduct(int[] arr)
        {
            int p = 1;
            bool found = false;
            foreach (int x in arr)
                if (x % 2 == 1) { p *= x; found = true; }
            return found ? p : 0;
        }

    }
}
