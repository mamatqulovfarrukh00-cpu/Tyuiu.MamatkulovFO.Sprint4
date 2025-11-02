using Tyuiu.MamatkulovFO.Sprint4.Task4.V10.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task4.V10.Test
{
    

    // Тесты для DataService
    [TestFixture]
    public class DataServiceTest
    {
        private DataService _service;

        [SetUp]
        public void Setup()
        {
            _service = new DataService();
        }

        [Test]
        public void Test_Calculate_ReplaceOddWithZero_WithGivenArray()
        {
            // Дано: массив 5x5 из задания
            int[,] array = {
            { 6, 6, 5, 3, 3 },
            { 5, 7, 4, 6, 4 },
            { 1, 2, 4, 1, 5 },
            { 1, 7, 2, 5, 7 },
            { 4, 2, 6, 5, 6 }
        };

            // Выполняем замену
            int[,] result = _service.Calculate(array);

            // Ожидаемый результат:
            int[,] expected = {
            { 6, 6, 0, 0, 0 },
            { 0, 0, 4, 6, 4 },
            { 0, 2, 4, 0, 0 },
            { 0, 0, 2, 0, 0 },
            { 4, 2, 6, 0, 6 }
        };

            // Проверяем каждый элемент
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }

        [Test]
        public void Test_Calculate_AllEven_ReturnsSame()
        {
            int[,] array = {
            { 2, 4, 6 },
            { 4, 2, 6 }
        };

            int[,] result = _service.Calculate(array);
            int[,] original = (int[,])array.Clone();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Assert.AreEqual(original[i, j], result[i, j]);
                }
            }
        }

        [Test]
        public void Test_Calculate_EmptyArray_ReturnsEmpty()
        {
            int[,] array = new int[0, 0];
            int[,] result = _service.Calculate(array);
            Assert.AreEqual(0, result.GetLength(0));
            Assert.AreEqual(0, result.GetLength(1));
        }
    }
}
