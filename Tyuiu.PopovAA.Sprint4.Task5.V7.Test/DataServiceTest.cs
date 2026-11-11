using Tyuiu.PopovAA.Sprint4.Task5.V7.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { -5, -4, -3 }, { -2, -1, 0 }, { 1, 2, 3 } };
            int res = ds.Calculate(array);
            Assert.AreEqual(5, res);
        }
    }
}
