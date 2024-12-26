using Methods;

namespace TestMehods
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetArrayColumn()
        {
            DataService ds = new DataService();
            string[,] data = { { "1", "3", "7" },
                            { "2", "7", "10" },
                            { "6", "9", "11" },
                            { "6", "9", "11" }};
            int[] res = ds.GetArrayColumn(data, 2);
            int[] expect = { 10, 11 };
            CollectionAssert.AreEqual(res, expect);
        }

        [TestMethod]
        public void CheckCalcAverageValue()
        {
            DataService ds = new DataService();
            int[] data = { 3, 3, 3 };
            double res = ds.CalcAverageValue(data, 2);
            double expect = 3.00;
            Assert.AreEqual(res, expect);
        }

        [TestMethod]
        public void CheckCalcMax()
        {
            DataService ds = new DataService();
            int[] data = { 3, 4, 5 };
            int res = ds.CalcMax(data);
            double expect = 5;
            Assert.AreEqual(res, expect);
        }


        [TestMethod]
        public void CheckCalcMin()
        {
            DataService ds = new DataService();
            int[] data = { 3, 4, 5 };
            int res = ds.CalcMin(data);
            double expect = 3;
            Assert.AreEqual(res, expect);
        }


        [TestMethod]
        public void CheckCalcSum()
        {
            DataService ds = new DataService();
            int[] data = { 3, 4, 5 };
            int res = ds.CalcSum(data);
            double expect = 12;
            Assert.AreEqual(res, expect);
        }
    }
}