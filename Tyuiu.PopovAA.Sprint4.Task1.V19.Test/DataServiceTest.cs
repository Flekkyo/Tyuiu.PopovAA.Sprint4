using Tyuiu.PopovAA.Sprint4.Task1.V19.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.Calculate(array);
            Assert.AreEqual(32, res);
        }
    }
}
