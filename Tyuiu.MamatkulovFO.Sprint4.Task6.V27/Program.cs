using Tyuiu.MamatkulovFO.Sprint4.Task6.V27.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            DataService ds = new DataService();
            int res = ds.Calculate(array);

            Console.WriteLine("Количество фигур, длина которых меньше 7:" + res);
            Console.ReadKey();
        }
    }
}
