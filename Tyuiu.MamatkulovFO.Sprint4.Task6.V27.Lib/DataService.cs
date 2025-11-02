using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MamatkulovFO.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            if (array == null)
                return 0;

            int count = 0;
            foreach (string item in array)
            {
                if (item.Length < 7)
                    count++;
            }
            return count;
        }
    }
}