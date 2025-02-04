// See https://aka.ms/new-console-template for more information

using ExtensionMethods;

Console.WriteLine("Hello, World!");
int number = 10;
var output = number.GetPower(3);

var dates = new DateTime[] { new DateTime(2025,1,1), new DateTime(2025,4,23), new DateTime(2025, 5, 19) };
var totalWorkDays = DateTime.Now.TotalWorkDays(dates);

Console.WriteLine($"Total Work Days: {totalWorkDays}");