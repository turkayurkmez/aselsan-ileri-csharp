// See https://aka.ms/new-console-template for more information
using Constructors;

ReportGenerator reportGenerator = new("C:\\bilmemne.xlsx");
reportGenerator.GenerateReport();

//reportGenerator.Format = "PDF";