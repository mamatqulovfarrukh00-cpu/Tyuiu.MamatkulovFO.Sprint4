using Tyuiu.MamatkulovFO.Sprint4.Task0.V23.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task0.V23
{
   

    class Program
    {
        static void Main()
        {
            var service = new DataService();

            
            int[] arr1 = { 9, 3, 7, 1, 5, 3, 2, 1, 7 };
            int result1 = service.GetMultOddArrEl(arr1);
            Console.WriteLine($"Test 1: {result1}"); 

            
            int[] arr2 = { 2, 4, 6 };
            int result2 = service.GetMultOddArrEl(arr2);
            Console.WriteLine($"Test 2 (Только четний): {result2}"); 

            
            try
            {
                service.GetMultOddArrEl(new int[0]);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Test 3 (свободно): ошибка — {ex.Message}");
            }

            Console.WriteLine("\n✅ все тесты закончилос.");
        }
    }
}
