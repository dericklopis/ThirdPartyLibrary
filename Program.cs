using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperAndJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Read data from CSV & Write data in CSV");
            //CSVHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.ReadKey();
        }
    }
}
