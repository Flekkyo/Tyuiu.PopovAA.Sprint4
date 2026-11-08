using Tyuiu.PopovAA.Sprint4.Task2.V14.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            int res = ds.Calculate(arr);
            Assert.AreEqual(15, res);
        }
    }
}
