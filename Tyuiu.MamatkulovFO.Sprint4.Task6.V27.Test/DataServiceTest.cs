using Tyuiu.MamatkulovFO.Sprint4.Task6.V27.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task6.V27.Test
{
   
    public class DataServiceTest
    {
        [Fact]
        public void Calculate_ValidData_ReturnsCorrectCount()
        {
            // Arrange
            var service = new DataService();
            string[] data = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };

            // Act
            int result = service.Calculate(data);

            // Assert
            Assert.AreEqual(1, result); // Faqat "Круг" — 4 harf, qolganlari 7 yoki undan ko'p
        }

        [Fact]
        public void Calculate_EmptyArray_ReturnsZero()
        {
            var service = new DataService();
            string[] data = { };
            int result = service.Calculate(data);
            Assert.AreEqual(0, result);
        }

        [Fact]
        public void Calculate_NullArray_ReturnsZero()
        {
            var service = new DataService();
            string[] data = null;
            int result = service.Calculate(data);
            Assert.AreEqual(0, result);
        }
    }
}
