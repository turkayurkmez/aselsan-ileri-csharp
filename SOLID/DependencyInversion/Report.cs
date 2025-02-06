using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Report
    {
        private ISender _sender;
        //public Report(ISender sender)
        //{
        //    _sender = sender;
        //}

        public Report()
        {
                
        }
        public ISender Sender { get; set; }
        public void Send()
        {
         //MailSender mailSender = new MailSender();
           // _sender.Send();
          Sender.Send();
        }
    }


    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        
       public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram...");
        }
    }
}
