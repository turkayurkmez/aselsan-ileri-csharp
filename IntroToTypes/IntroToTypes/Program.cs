// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı giriniz (0...255)");
byte first = byte.Parse(Console.ReadLine());
Console.WriteLine("Bir sayı daha giriniz (0...255)");

byte second = byte.Parse(Console.ReadLine());

checked
{
    byte total = (byte)(first + second);
    Console.WriteLine(total);
}
