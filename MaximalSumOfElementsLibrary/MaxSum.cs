namespace MaximalSumOfElementsLibrary
{
    public class MaxSum
    {

        public Report GetFromArray(decimal[][] input)
        {
            Report report = new Report();

            ArgumentNullException.ThrowIfNull(input);

            var sumValueAndRowNumbers = GetMaxSumAndRowNumbers(input);

            report.MaxSumValue = sumValueAndRowNumbers.Item1;
            report.RowsNumberWithMax = sumValueAndRowNumbers.Item2;
            report.RowsNumberWrongElements = GetRowsNumberWrongElements(input);

            return report;
        }

        private Tuple <decimal,List<int>> GetMaxSumAndRowNumbers( decimal[][] input)
        {
            decimal maxSum = decimal.MinValue;
            List<int> rowsNumber = new List<int>();

            for (int rowIndex = 0; rowIndex < input.Length; rowIndex++)
            {
                if (input[rowIndex] == null || input[rowIndex].Length == 0)
                {
                    continue;
                }

                decimal sum = input[rowIndex].Sum();
                if (sum >= maxSum)
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowsNumber.Clear();                      
                    }
                    rowsNumber.Add(rowIndex + 1);
                }
            }
            return Tuple.Create(maxSum, rowsNumber);
        }

        private List<int> GetRowsNumberWrongElements(decimal[][] input)
        {
            List<int> rowsNumber = new List<int>();

            for (int rowIndex = 0; rowIndex < input.Length; rowIndex++)
            {
                if (input[rowIndex] == null || input[rowIndex].Length == 0)
                {
                    rowsNumber.Add(rowIndex + 1);
                }
            }
            return rowsNumber;
        }
    }
}
