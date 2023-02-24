using System.Globalization;

namespace MaximalSumOfElementsLibrary
{
    public class Parser
    {
        public decimal[][] ToDecimalArray(string[] input)
        {
            ArgumentNullException.ThrowIfNull(input);

            decimal[][]? decArray = new decimal[input.Length][] ;

            for (int rowIndex = 0; rowIndex < input.Length; rowIndex++)
            {
                if (string.IsNullOrEmpty(input[rowIndex]))
                {
                    decArray[rowIndex] = new decimal[0];
                    continue;
                }

                string[] line = input[rowIndex].Split(',');

                decArray[rowIndex] = new decimal[line.Length];

                for (int elementIndex = 0; elementIndex < line.Length; elementIndex++)
                {
                    decimal temp;
                    if (!decimal.TryParse(line[elementIndex], NumberStyles.Float, CultureInfo.InvariantCulture, out temp))
                    {
                        decArray[rowIndex] = null;
                        break;
                    }
                    decArray[rowIndex][elementIndex] = temp;
                }
            }
            return decArray;
        }
    }
}