using Matrix2DLib;
namespace Matrix2dTest
{
    [TestClass]
    public sealed class Matrix2dConstructor
    {
        [TestMethod]
        public void Test_Full_Constructor()
        {
            var m = new Matrix2D(1, 2, 3, 4);
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }
    }
}
