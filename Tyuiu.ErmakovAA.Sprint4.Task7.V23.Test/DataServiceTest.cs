using Tyuiu.ErmakovAA.Sprint4.Task7.V23.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(5, dataService.Calculate(4, 3, "678135972584"));
        }
    }
}