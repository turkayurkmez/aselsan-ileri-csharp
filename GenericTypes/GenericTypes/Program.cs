// See https://aka.ms/new-console-template for more information
using GenericTypes;

Console.WriteLine("Hello, World!");
PointGeneric<decimal> pointDecimal = new PointGeneric<decimal>();
pointDecimal.X = 1.0M;
pointDecimal.Y = 2.0M;

Console.WriteLine(pointDecimal);
pointDecimal.Reset();
Console.WriteLine(pointDecimal);

PointGeneric<short> pointGeneric = new PointGeneric<short>();