using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22
{
    
    
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Демонстрация работы DataService:");
                Console.WriteLine("================================");

                var service = new DataService();
                int[] array = { 9, 3, 7, 1, 5, 3, 2, 1, 7 };

                try
                {
                    int result = service.GetMultOddArrEl(array);
                    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
                    Console.WriteLine($"Произведение нечётных элементов: {result}");
                    Console.WriteLine("\n✅ Ожидаемый результат: 39690");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Ошибка: {ex.Message}");
                }

                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    
}
