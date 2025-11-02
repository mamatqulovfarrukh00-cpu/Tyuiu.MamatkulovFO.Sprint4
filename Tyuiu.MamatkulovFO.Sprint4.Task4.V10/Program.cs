using Tyuiu.MamatkulovFO.Sprint4.Task4.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task4.V10
{
   

   
    class Program
    {
        static void Main()
        {
            var service = new DataService();

            // Статический массив 5x5 из задания
            int[,] array = {
            { 6, 6, 5, 3, 3 },
            { 5, 7, 4, 6, 4 },
            { 1, 2, 4, 1, 5 },
            { 1, 7, 2, 5, 7 },
            { 4, 2, 6, 5, 6 }
        };

            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Заменяем нечётные элементы на 0 — получаем новый массив
            int[,] result = service.Calculate(array);

            // Выводим результат
            Console.WriteLine("\nМассив после замены нечётных на 0:");
            PrintArray(result);

            Console.ReadKey(); // Ожидание нажатия клавиши
        }

        // Вспомогательный метод для вывода массива
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
