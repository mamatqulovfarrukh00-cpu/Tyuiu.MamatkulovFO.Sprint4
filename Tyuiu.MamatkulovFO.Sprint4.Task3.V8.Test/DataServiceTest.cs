using Tyuiu.MamatkulovFO.Sprint4.Task3.V8.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task3.V8.Test
{

   
    public class DataServiceTest
    {
        private DataService _service;

        [SetUp]
        public void Setup()
        {
            _service = new DataService();
        }

        [Test]
        public void Test_Calculate_MinInFourthColumn_WithGivenArray()
        {
            // Дано: массив 5x5 из задания
            int[,] array = {
            { 4, 8, 3, 4, 8 },
            { 5, 3, 5, 7, 8 },
            { 3, 7, 2, 7, 7 },
            { 5, 2, 4, 6, 4 },
            { 4, 4, 6, 7, 2 }
        };

            // Четвёртый столбец (индекс 3): {4, 7, 7, 6, 7} → минимум = 4
            int result = _service.Calculate(array);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_Calculate_SingleRow()
        {
            int[,] array = { { 1, 2, 3, 4, 5 } };
            int result = _service.Calculate(array);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_Calculate_AllSameInFourthColumn()
        {
            int[,] array = {
            { 1, 1, 1, 5, 1 },
            { 1, 1, 1, 5, 1 },
            { 1, 1, 1, 5, 1 },
            { 1, 1, 1, 5, 1 },
            { 1, 1, 1, 5, 1 }
        };
            int result = _service.Calculate(array);
            Assert.AreEqual(5, result);
        }

        
      
    }
}
