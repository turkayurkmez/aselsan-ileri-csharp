using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{

    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} yerinden {to} yerine kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine($"{from} yerinden {to} yerine taşındı");
        }

        public abstract void Save();
        public abstract void Open();

       

    }


    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("PDF dosyası açıldı");
        }

        public override void Print()
        {
            Console.WriteLine("PDF dosyası yazdırıldı");

        }

        public override void Save()
        {

            Console.WriteLine("PDF dosyası kaydedildi");
        }
    }

    public class WordDocument : Document , IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Word dosyası açıldı");
        }
        public  void Print()
        {
            Console.WriteLine("Word dosyası yazdırıldı");
        }
        public override void Save()
        {
            Console.WriteLine("Word dosyası kaydedildi");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Excel dosyası açıldı");
        }
        public void Print()
        {
            Console.WriteLine("Excel dosyası yazdırıldı");
        }
        public override void Save()
        {
            Console.WriteLine("Excel dosyası kaydedildi");
        }
    }

    public class DocumentPrinter
    {
        public void PrintDocument(  document) {
            document.Print();
        }
    }
}
