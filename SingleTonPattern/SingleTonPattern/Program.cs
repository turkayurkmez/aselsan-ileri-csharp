// See https://aka.ms/new-console-template for more information
using SingleTonPattern;

Console.WriteLine("Hello, World!");

var config = MailConfiguration.Create();
config.Host = "smtp.gmail.com";

var config2 = MailConfiguration.Create();
Console.WriteLine(config2.Host);

var config3 = MailConfiguration.Create();
var config4 = MailConfiguration.Create();
var config5 = MailConfiguration.Create();
Console.WriteLine(config5.Host + " " + config3.Host);


