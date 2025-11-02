using Tyuiu.MamatkulovFO.Sprint4.Task0.V23.Lib;

namespace Tyuiu.MamatkulovFO.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultOddArrEl_TestV23_Returns39690()
        {
            
            
            int[] array = { 9, 3, 7, 1, 5, 3, 2, 1, 7 };
            int expected = 39690; 
            int actual = service.GetMultOddArrEl(array);
            Assert.AreEqual(expected, actual);
        }
    }
}

