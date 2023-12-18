using myWorkspace;

namespace MainWorkspace_Tests
{
    [TestClass]
    public class classMainWorkspace_Tests
    {
        [TestMethod]
        public void CalcAreaCirculo_ReturnsCorrectValue()
        {
            const double radio = 5, expected = 78.53981633974483;
            double result;

            result = myClass.CalcAreaCirculo(radio);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalcAreaPentagono_ReturnsCorrectValue()
        {
            const double side = 5, expected = 0.0;
            double result;

            result = myClass.CalcAreaPentagono(side);

            Assert.AreEqual(expected, result);
        }
    }
}