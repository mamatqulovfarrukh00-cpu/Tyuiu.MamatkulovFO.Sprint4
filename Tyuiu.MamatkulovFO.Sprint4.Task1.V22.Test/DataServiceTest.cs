using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultOddArrEl_Variant23_Returns39690()
        {
            // Подготовка
           
            int[] inputArray = { 9, 3, 7, 1, 5, 3, 2, 1, 7 }; // из вашего задания
            int expected = 39690; // 9*3*7*1*5*3*1*7

            // Действие
            int actual = service.GetMultOddArrEl(inputArray);

            // Проверка
            Assert.AreEqual(expected, actual, "Результат не совпадает с ожидаемым.");
        }
    }
}
