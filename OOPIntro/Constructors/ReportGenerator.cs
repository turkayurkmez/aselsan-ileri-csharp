using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class ReportGenerator
    {
        public string ExcelFilePath { get; set; }
        public string Format { get; set; }

        //public ReportGenerator(): this("PDF")
        //{

            
        //}

        public ReportGenerator(string path)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(path, nameof(path));
            ExcelFilePath = path;


        }

        public void GenerateReport()
        {
            Console.WriteLine("Rapor oluşturuldu");
        }
    }
}
