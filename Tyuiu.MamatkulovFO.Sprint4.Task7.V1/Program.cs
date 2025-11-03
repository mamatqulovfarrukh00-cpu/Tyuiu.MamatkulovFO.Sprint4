using Tyuiu.MamatkulovFO.Sprint4.Task7.V1.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V1
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("=== Преобразование строки в матрицу 3x3 и подсчёт чётных цифр ===");
                Console.Write("Введите строку из 9 однозначных цифр (например: 135792468): ");
                string input = Console.ReadLine()?.Trim();

                try
                {
                    var service = new DataService();
                    int evenCount = service.Calculate(3, 3, input);

                    // Вывод результата
                    Console.WriteLine($"\nКоличество чётных цифр: {evenCount}");

                    // Дополнительно: вывод матрицы 3x3
                    Console.WriteLine("\nМатрица 3x3:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(input[i * 3 + j] + " ");
                        }
                        Console.WriteLine(); // Перевод строки
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nОшибка: {ex.Message}");
                }

                Console.WriteLine("\nНажмите любую клавишу для завершения...");
                Console.ReadKey();
            }
        }
    
}

  
    