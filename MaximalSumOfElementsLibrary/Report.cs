using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSumOfElementsLibrary
{
    public class Report
    {
        public decimal MaxSumValue { get; set; } = decimal.MinValue;
        public List<int> RowsNumberWithMax { get; set; } = new List<int>();
        public List<int> RowsNumberWrongElements { get; set; } = new List<int>();
    }
}
