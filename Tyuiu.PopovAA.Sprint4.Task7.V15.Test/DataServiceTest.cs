using Tyuiu.PopovAA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3, 5, "312456234456234");
            Assert.AreEqual(6, res);
        }
    }
}
