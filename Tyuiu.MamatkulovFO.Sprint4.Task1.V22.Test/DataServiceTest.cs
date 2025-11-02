using Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Lib;
namespace Tyuiu.MamatkulovFO.Sprint4.Task1.V22.Test
{

    

    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CalculateOddProduct_WithDuplicates_Returns295245()
        {
            var service = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            Assert.AreEqual(295245, service.CalculateOddProduct(array));
        }

        [Test]
        public void CalculateOddProduct_UniqueOnly_Returns135()
        {
            var service = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            Assert.AreEqual(135, service.CalculateOddProduct(array, true));
        }
    }
}
