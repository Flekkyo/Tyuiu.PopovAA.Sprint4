using Tyuiu.PopovAA.Sprint4.Task0.V3.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = ds.GetMultOddArrEl(arr);
            Assert.AreEqual(945, res);
        }
    }
}
