using MaximalSumOfElementsLibrary;

namespace MaximalSumOfElementsLibraryTest
{
    [TestClass]
    public class ReaderTest
    {
        [TestMethod]
        public async Task ReadFileAsync_PathToFile()
        {
            string[]? expected =  new string[1] { "AbCd" };

            Reader reader = new Reader();
            var res = await reader.ReadFileAsync("Resources\\Test.txt");

            CollectionAssert.AreEqual(expected, res);            
        }

        [TestMethod]
        public void ReadFileAsync_EmptyFile()
        {
            Reader reader = new Reader();
            var res = reader.ReadFileAsync("Resources\\TestEmptyFile.txt");
            Assert.IsTrue(res.Result.Length == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public async Task ReadFileAsync_FileNotFoundException()
        {
            Reader reader = new Reader();

            var res = await reader.ReadFileAsync("  ");
           ;
        }
    }
}