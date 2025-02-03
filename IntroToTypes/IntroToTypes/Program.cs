// See https://aka.ms/new-console-template for more information
try
{
	Console.WriteLine("Bir sayı giriniz (0...255)");
	byte first = byte.Parse(Console.ReadLine());
	Console.WriteLine("Bir sayı daha giriniz (0...255)");

	byte second = byte.Parse(Console.ReadLine());

	checked
	{
		byte total = (byte)(first + second);
		Console.WriteLine(total);
	}
}
catch (FormatException format)
{

    Console.WriteLine("Lütfen sayısal...");
}
catch (OverflowException overflow)
{
    Console.WriteLine("Taşma hatası...");
}
catch (Exception ex)
{
    Console.WriteLine("Bir hata oluştu...");
}

/*
 * https://github.com/turkayurkmez/aselsan-ileri-csharp
 */