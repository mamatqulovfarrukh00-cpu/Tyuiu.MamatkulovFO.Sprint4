using Tyuiu.MamatkulovFO.Sprint4.Task7.V1.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task7.V1.Test
{
    
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void Calculate_ValidInput_ReturnsCorrectEvenCount()
            {
                // Подготовка
                var service = new DataService();
                string input = "135792468"; // чётные: 2, 4, 6, 8 → 4 шт.

                // Действие
                int result = service.Calculate(3, 3, input);

                // Проверка
                Assert.AreEqual(4, result);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Calculate_InputTooShort_ThrowsException()
            {
                var service = new DataService();
                service.Calculate(3, 3, "12345"); // только 5 символов
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Calculate_InputContainsNonDigit_ThrowsException()
            {
                var service = new DataService();
                service.Calculate(3, 3, "12a456789"); // 'a' — не цифра
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Calculate_NullInput_ThrowsException()
            {
                var service = new DataService();
                service.Calculate(3, 3, null);
            }
        }
    
}
