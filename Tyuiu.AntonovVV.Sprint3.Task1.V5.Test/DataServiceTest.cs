using Tyuiu.AntonovVV.Sprint3.Task1.V5.Lib;
namespace Tyuiu.AntonovVV.Sprint3.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 13;

            var res = ds.GetMultiplySeries(startValue, stopValue, value);

            Assert.AreEqual(1, res);
        }
    }
}