using Tyuiu.MamatkulovFO.Sprint4.Task3.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task3.V8
{
    

    // Консольное приложение — точка входа
    class Program
    {
        static void Main()
        {
            var service = new DataService();

            // Статический массив 5x5 из задания
            int[,] array = {
            { 4, 8, 3, 4, 8 },
            { 5, 3, 5, 7, 8 },
            { 3, 7, 2, 7, 7 },
            { 5, 2, 4, 6, 4 },
            { 4, 4, 6, 7, 2 }
        };

            // Выводим массив для наглядности
            Console.WriteLine("Дан массив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Находим минимальный элемент в 4-м столбце (индекс 3)
            int minInFourthColumn = service.FindMinInFourthColumn(array);

            // Выводим результат
            Console.WriteLine($"\nМинимальный элемент в четвёртом столбце: {minInFourthColumn}");
            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }
}
