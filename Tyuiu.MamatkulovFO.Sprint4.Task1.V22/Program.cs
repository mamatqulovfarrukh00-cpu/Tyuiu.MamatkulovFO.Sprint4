using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22
{
    class Program
    {
        static void Main()
        {
            // Создаём экземпляр сервиса
            var service = new DataService();

            // Заданный массив
            int[] numbers = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };

            // Вычисляем произведение нечётных
            int result = service.CalculateOddProduct(numbers);

            // Выводим результат
            Console.WriteLine($"Произведение нечётных элементов: {result}");
            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }

}
