using Tyuiu.MamatkulovFO.Sprint4.Task5.V30.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var service = new DataService();

            // 5x5 massiv (misol uchun)
            int[,] matrix = {
                { -1, 2, 0, 3, -2 },
                { 1, -3, 4, 0, 2 },
                { -4, 1, -2, 3, 1 },
                { 0, 2, -1, 4, -3 },
                { 3, -2, 1, 0, 2 }
            };

            int result = service.Calculate(matrix);
            Assert.AreEqual(30, result); // 2+3+1+4+2+1+3+1+2+4+3+1+2 = 30
        }
    }
}