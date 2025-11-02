using Tyuiu.MamatkulovFO.Sprint4.Task2.V29.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task2.V29.Test
{
   
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
        public void Test_Calculate_EvenProduct_WithMixedNumbers()
        {
            // Массив из 11 элементов (как в задании)
            int[] array = { 3, 6, 2, 7, 4, 1, 8, 5, 2, 3, 6 };

            // Чётные: 6, 2, 4, 8, 2, 6 → произведение = 6*2*4*8*2*6 = 4608
            int result = _service.Calculate(array);

            Assert.AreEqual(4608, result);
        }

        [Test]
        public void Test_Calculate_NoEvens_ReturnsZero()
        {
            int[] array = { 1, 3, 5, 7, 1, 3, 5 }; // Все нечётные
            int result = _service.Calculate(array);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_Calculate_EmptyArray_ReturnsZero()
        {
            int[] array = new int[0];
            int result = _service.Calculate(array);
            Assert.AreEqual(0, result);
        }
    }
}
