using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperAndJson
{
    class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = "C:\\Users\\91910\\source\\repos\\CSVHelperAndJson\\CSVHelperAndJson\\Utility\\Address.csv";
            string exportFilePath = "C:\\Users\\91910\\source\\repos\\CSVHelperAndJson\\CSVHelperAndJson\\Utility\\Export.csv";
            
        
            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.firstname);
                    Console.Write("\t" + addressData.lastname);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.code);
                    Console.WriteLine();

                }
                Console.WriteLine("**********************Reading from csv file and Write to csv file **************************");
                //Writing csv file

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
            //Console.WriteLine(reader);
        }


    }



}