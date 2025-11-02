using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Test
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
        public void Test_OddProduct_WithGivenArray()
        {
            // Дано: массив из задания
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };

            // Когда: вычисляем произведение нечётных
            int result = _service.CalculateOddProduct(array);

            // Тогда: результат должен быть равен 5 * 3 * 9 * 9 * 9 * 3 * 9 = 295245
            Assert.AreEqual(295245, result);
        }

        [Test]
        public void Test_OddProduct_WithNoOdds_ReturnsZero()
        {
            int[] array = { 2, 4, 6, 8 };
            int result = _service.CalculateOddProduct(array);
            Assert.AreEqual(0, result);
        }

        private class SetUpAttribute : Attribute
        {
        }
    }
}
