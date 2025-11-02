using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22
{
    class Program
    {
        static void Main()
        {
            var s = new DataService();
            int[] a = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            Console.WriteLine(s.CalculateOddProduct(a)); // 295245
        }
    }

}
