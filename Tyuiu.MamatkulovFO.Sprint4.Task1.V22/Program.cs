using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22
{
    class Program
    {
        static void Main()
        {
            // Создаём сервис
            var service = new DataService();

            // Массив из задания
            int[] arr = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };

            // Вычисляем и выводим результат
            int result = service.CalculateOddProduct(arr);

            System.Console.WriteLine(result); // Выведет: 135

            // Для ожидания (необязательно)
            System.Console.ReadKey();
        }
    }
}