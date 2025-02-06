// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();   
//Report report = new Report();
//report.Send(mailSender);

Report report = new Report();
report.Sender = mailSender;
report.Send();

report.Sender = whatsAppSender;
report.Send();

report.Sender = telegramSender;
report.Send();


//Report report1 = new Report(telegramSender);
//report1.Send();

//Report report2 = new Report(whatsAppSender);
//report2.Send();
//report.mailSender = mailSender;
