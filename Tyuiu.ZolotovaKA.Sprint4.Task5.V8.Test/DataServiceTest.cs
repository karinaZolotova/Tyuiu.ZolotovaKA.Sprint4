using Tyuiu.ZolotovaKA.Sprint4.Task5.V8.Lib;
namespace Tyuiu.ZolotovaKA.Sprint4.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();


            int[,] mas4 = new int[5, 5]
             { { 2, -1, 3, -2, 4 },
             { 0, -3, 1, 2, -1 },
             { 3, 4, -2, 0, 1 },
             { -1, 2, 3, -3, 4 },
             { 2, 0, -1, 3, -2 } };


            int[,] res = ds.Calculate(mas4);


            int[,] wait = new int[5, 5]
            { { 2, 0, 3, 0, 4 },
            { 0, 0, 1, 2, 0 },
            { 3, 4, 0, 0, 1 },
            { 0, 2, 3, 0, 4 },
            { 2, 0, 0, 3, 0 } };


            CollectionAssert.AreEqual(wait, res);
        }
    }
}