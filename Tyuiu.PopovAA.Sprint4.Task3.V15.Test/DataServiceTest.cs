using Tyuiu.PopovAA.Sprint4.Task3.V15.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 8, 4, 2, 5, 3 },
                             { 4, 3, 2, 5, 6 },
                             { 6, 3, 4, 7, 5 },
                             { 5, 7, 4, 3, 8 },
                             { 7, 8, 8, 5, 6 } };

            var res = ds.Calculate(array);
            Assert.AreEqual(12, res);
        }
    }
} 
