using MaximalSumOfElements.Properties;
using MaximalSumOfElementsLibrary;

namespace MaximalSumOfElements
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ConsoleHelper helper = new ConsoleHelper();
            Reader reader = new Reader();
            Parser parser = new Parser();
            MaxSum sum = new MaxSum();

            try
            {
                Console.WriteLine(Resources.Greeting);

                var filePath = helper.CheckMainArgs(args);                  
                var rowOfFile = await reader.ReadFileAsync(filePath); 
                var decArray = parser.ToDecimalArray(rowOfFile);

                Report report = sum.GetFromArray(decArray);

                Console.WriteLine(string.Format(Resources.MaxSum, string.Join("", report.MaxSumValue)));
                Console.WriteLine(string.Format(Resources.NumberOfLine, string.Join(",", report.RowsNumberWithMax)));              
                Console.WriteLine(string.Format(Resources.ListOfWrongLine, string.Join(",", report.RowsNumberWrongElements)));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading the file! " + ex.ToString());
            }
        }
    }
}