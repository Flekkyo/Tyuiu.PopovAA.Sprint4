using Tyuiu.PopovAA.Sprint4.Task6.V8.Lib;
namespace Tyuiu.PopovAA.Sprint4.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            var res = ds.Calculate(array);
            string[] otv = { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            CollectionAssert.AreEqual(otv, res);
        }
    }
}
