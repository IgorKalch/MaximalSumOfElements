using MaximalSumOfElements.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSumOfElements
{
    public class ConsoleHelper
    {
        public string CheckMainArgs(string[] args)
        {
            string filePath = null;

            if (args == null || args.Length == 0)
            {
                Console.WriteLine(Resources.InputMessage);
                filePath = Console.ReadLine();
            }
            else
            {
                filePath = args[0];
            }
            return filePath;
        } 
    }
}
