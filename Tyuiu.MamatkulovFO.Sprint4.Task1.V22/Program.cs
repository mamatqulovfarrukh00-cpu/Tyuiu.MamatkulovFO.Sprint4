using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22
{
    class Program
    {
        static void Main()
        {
            var service = new DataService();
            int[] arr = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };

            int result = service.CalculateOddProduct(arr);

            System.Console.WriteLine(result); // Выведет: 295245

            System.Console.ReadKey();
        }
    }
}