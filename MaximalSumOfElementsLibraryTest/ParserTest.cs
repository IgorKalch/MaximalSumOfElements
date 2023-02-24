using MaximalSumOfElementsLibrary;
using System.Globalization;

namespace MaximalSumOfElementsLibraryTest
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void ToDecimalArray_Input_EmptyLine()
        {
            Parser parser = new Parser();

            var actual = parser.ToDecimalArray(new string[] { "" });

            Assert.AreEqual(0, actual[0].Length);
        }

        [TestMethod]
        public void ToDecimalArray_Input_NonNumericLine()
        {
            Parser parser = new Parser();

            var actual = parser.ToDecimalArray(new string[] { "Abc" });

            Assert.AreEqual(null, actual[0]);
        }

        [TestMethod]
        public void ToDecimalArray_Input_NumericLine()
        {
            Parser parser = new Parser();

            var expected = new decimal[][] { new decimal[] { 3.08M } };
            var actual = parser.ToDecimalArray(new string[] { "3.08" });

            Assert.AreEqual(expected[0][0], actual[0][0]);
        }

        [TestMethod]
        public void ToDecimalArray_Input_NumericLineWithSpace()
        {
            Parser parser = new Parser();

            decimal[][] actual = parser.ToDecimalArray(new string[] { " 3.08 " });

            Assert.AreEqual(3.08M, actual[0][0]);
        }

        [TestMethod]
        public void ToDecimalArray_WrongInput_NumericLineWithSpace()
        {
            Parser parser = new Parser();

            decimal[][] actual = parser.ToDecimalArray(new string[] { "3. 08" });

            Assert.AreEqual(null, actual[0]);
        }

        [TestMethod]
        public void ToDecimalArray_Input_Culture()
        {
            Parser parser = new Parser();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            var expected = new decimal[][] { new decimal[] { 1.1M } };
            var actual = parser.ToDecimalArray(new string[] { "1.1" });

            Assert.AreEqual(expected[0][0], actual[0][0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToDecimalArray_ErrorNull()
        {
            Parser parser = new Parser();
            parser.ToDecimalArray(null);
        }
    }
}