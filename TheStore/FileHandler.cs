using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TheStore
{
    class FileHandler
    {
        private static readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\" + "Lager.csv";

        /// <summary>  
        ///  This function reads from file and add to stock products.
        /// </summary> 
        public List<Product> ReadCSV()
        {
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            using (CsvReader csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<Product>();
                return records.ToList();
            }
        }

        /// <summary>  
        ///  This function write to file when a product is added or removed from stock.
        /// </summary> 
        public void WriteCSV(List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath,false, Encoding.UTF8))
            {
                using (CsvWriter csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(products);
                }
                writer.Close();
            }
        }
    }
}
