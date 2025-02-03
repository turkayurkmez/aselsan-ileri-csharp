// See https://aka.ms/new-console-template for more information
using ClassANDObject;

Console.WriteLine("Hello, World!");
Musteri ismail = new Musteri();

ismail.Ad = "İsmail";

Musteri neriman = ismail;

neriman.Ad = "Neriman";

Console.WriteLine(ismail.Ad);
object a = new Musteri();
object b = "Bu bir cümle";
object c = 1;
object d = 1.5;
object e = "e";

string cumle = (string)c;

Console.WriteLine(cumle.ToUpper());

object birseyYap(object birSey)
{
    return null;
}

birseyYap("deneme");
birseyYap(15);