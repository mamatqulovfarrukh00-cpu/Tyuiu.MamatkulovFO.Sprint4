using Tyuiu.MamatkulovFO.Sprint4.Task5.V30.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task5.V30
{
        class Program
        {
            static void Main(string[] args)
            {
                int[,] matrix = new int[5, 5];
                Random rand = new Random();

                Console.WriteLine("Массив:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matrix[i, j] = rand.Next(-2, 5);
                        Console.Write(matrix[i, j].ToString().PadLeft(4));
                    }
                    Console.WriteLine();
                }

                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] > 0)
                            sum += matrix[i, j];
                    }
                }

                Console.WriteLine($"\nСумма положительных элементов = {sum}");
                Console.ReadKey();
            }
        }
    
}
