using MaximalSumOfElementsLibrary;

namespace MaximalSumOfElementsLibraryTest
{
    [TestClass]
    public class MaxSumTest
    {
        [TestMethod]
        public void GetFromArray_PositiveNumbers()
        {
            MaxSum max = new MaxSum();

            var expectedSum = 4;
            var expectedRowNmber = new List<int>();
            expectedRowNmber.AddRange(new[] { 1 });

            decimal[][] array = new decimal[2][] {
                                new decimal[2] { 2, 2 },
                                new decimal[2] { 1, 1 }
                            };
            Report report = max.GetFromArray(array);

            Assert.AreEqual(expectedSum, report.MaxSumValue);
            CollectionAssert.AreEqual(expectedRowNmber, report.RowsNumberWithMax);
        }

        [TestMethod]
        public void GetFromArray_NegativeNumbers()
        {
            MaxSum max = new MaxSum();

            var expectedSum = -2;
            var expectedRowNmber = new List<int>();
            expectedRowNmber.AddRange(new[] { 2 });

            decimal[][] array = new decimal[2][] {
                                new decimal[2] { -2, -2 },
                                new decimal[2] { -1, -1 }
                            };
            Report report = max.GetFromArray(array);

            Assert.AreEqual(expectedSum, report.MaxSumValue);
            CollectionAssert.AreEqual(expectedRowNmber, report.RowsNumberWithMax);
        }

        [TestMethod]
        public void GetFromArray_ZeroValue()
        {
            MaxSum max = new MaxSum();

            var expectedSum = 0;
            var expectedRowNmber = new List<int>();
            expectedRowNmber.AddRange(new[] { 2 });

            decimal[][] array = new decimal[2][] {
                                new decimal[2] { -2, -2 },
                                new decimal[2] { 0, 0 }
                            };
            Report report = max.GetFromArray(array);

            Assert.AreEqual(expectedSum, report.MaxSumValue);
            CollectionAssert.AreEqual(expectedRowNmber, report.RowsNumberWithMax);
        }

        [TestMethod]
        public void GetFromArray_MaxInTwoLines()
        {
            MaxSum max = new MaxSum();

            var expectedSum = 4;
            var expectedRowNmber = new List<int>();
            expectedRowNmber.AddRange(new[] { 1, 3 });

            decimal[][] array = new decimal[3][] {
                                new decimal[2] { 2, 2 },
                                new decimal[2] { -1, -1 },
                                new decimal[2] { 2, 2 }
                            };
            Report report = max.GetFromArray(array);

            Assert.AreEqual(expectedSum, report.MaxSumValue);
            CollectionAssert.AreEqual(expectedRowNmber, report.RowsNumberWithMax);
        }

        [TestMethod]
        public void GetFromArray_WrongElements_Null()
        {
            MaxSum max = new MaxSum();

            var expected = new List<int>();
            expected.AddRange(new[] { 1 });

            decimal[][] array = new decimal[1][] {
                                null
                            };
            Report report = max.GetFromArray(array);

            CollectionAssert.AreEqual(expected, report.RowsNumberWrongElements);
        }

        [TestMethod]
        public void GetFromArray_WrongAndNormaldata()
        {
            MaxSum max = new MaxSum();

            var expectedMaxSumValue = 5;
            var expectedNumberWithMax = new List<int>();
            expectedNumberWithMax.AddRange(new[] { 1,6 });
            var expectedNumberWrongElements = new List<int>();
            expectedNumberWrongElements.AddRange(new[] { 4,5 });

            decimal[][] array = new decimal[6][] {
                                new decimal[2] { 2, 3 },
                                new decimal[2] { -1, -1 },
                                new decimal[2] { 2, 2 },
                                new decimal[0] { },
                                null,
                                new decimal[2] { 2, 3 }
                            };
            Report report = max.GetFromArray(array);

            Assert.AreEqual(expectedMaxSumValue, report.MaxSumValue);
            CollectionAssert.AreEqual(expectedNumberWithMax, report.RowsNumberWithMax);
            CollectionAssert.AreEqual(expectedNumberWrongElements, report.RowsNumberWrongElements);
        }



        [TestMethod]
        public void GetFromArray_EmptyArray()
        {
            MaxSum max = new MaxSum();

            var expected = new List<int>();
            expected.AddRange(new[] { 1 });

            decimal[][] array = new decimal[1][] {
                                new decimal[0] { }
                            };
            Report report = max.GetFromArray(array);

            CollectionAssert.AreEqual(expected, report.RowsNumberWrongElements);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFromArray_ErrorArrayNull()
        {
            MaxSum max = new MaxSum();
            max.GetFromArray(null);
        }      
    }
}