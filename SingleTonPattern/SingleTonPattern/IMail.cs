using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    public interface IMailConfiguration
    {
        bool EnableSsl { get; set; }
        string Host { get; set; }
        int Port { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

        void ConfigurMail(string to, string subject, string body);

    }

    public class MailConfiguration : IMailConfiguration
    {

        private MailConfiguration()
        {
            
        }

        private static MailConfiguration instance;
        public static MailConfiguration Create() {

            if (instance == null)
            {
                instance = new MailConfiguration();
            }
            return instance;

        }
        public bool EnableSsl { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void ConfigurMail(string to, string subject, string body)
        {
            Console.WriteLine("Gmail'e göre....");
        }
    }


}
