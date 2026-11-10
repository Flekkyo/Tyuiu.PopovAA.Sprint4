using Tyuiu.PopovAA.Sprint4.Task4.V10.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] res = ds.Calculate(array);
            int[,] new_array = { { 0, 2, 0 }, { 4, 0, 6 }, { 0, 8, 0 } };
            CollectionAssert.AreEqual(new_array, res);
        }
    }
}
