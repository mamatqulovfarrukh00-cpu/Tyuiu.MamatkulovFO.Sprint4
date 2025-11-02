using Tyuiu.MamatkulovFO.Sprint4.Task2.V29.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task2.V29
{
    

    // Главная программа — точка входа
    class Program
    {
        static void Main()
        {
            var service = new DataService();

            // Генерируем массив из 11 случайных чисел от 1 до 8
            Random rand = new Random();
            int[] numbers = new int[11];

            Console.Write("Сгенерированный массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 9); // от 1 до 8 включительно
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Вычисляем произведение чётных элементов
            int result = service.Calculate(numbers);

            // Выводим результат
            Console.WriteLine($"Произведение чётных элементов: {result}");
            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }
}
