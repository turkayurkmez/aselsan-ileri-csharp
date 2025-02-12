using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPLibrary
{
    /*
     *   Tüm haberleşme için (TCP, Udp, SerialPort) için bir kütüphane oluşturulacak.
     *  
     */

    public interface IConnectionProvider
    {
        void Send();
        void Receive();
      
    }

    public interface IConnectionSettings
    {
        void Connect();
        void Disconnect();
    }


    public interface IEthernetSettings : IConnectionSettings
    {
        int Port { get; set; }
        string IpAddress { get; set; }
    }

    public class UdpMessenger : IConnectionProvider
    {
        
      

        public void Receive()
        {
            Monitor.Enter(this);
            throw new NotImplementedException();

            Monitor.Exit(this);
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class TcpMessenger : IConnectionProvider
    {
        public void Receive()
        {
            throw new NotImplementedException();
        }
        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class SerialPortMessenger : IConnectionProvider
    {
        public void Receive()
        {
            throw new NotImplementedException();
        }
        public void Send()
        {
            throw new NotImplementedException();
        }
    }


   public class MessageProcessor<T> where T:IConnectionProvider,new ()
    {
        private readonly IConnectionSettings connectionSettings;
        //private IConnectionProvider _connectionProvider;
        private T _connectionProvider = new();
        public MessageProcessor(IConnectionSettings connectionSettings)
        {
            this.connectionSettings = connectionSettings;
            //_connectionProvider = connectionProvider;
        }
        public void Process()
        {
            connectionSettings.Connect();
            _connectionProvider.Send();
            _connectionProvider.Receive();
            connectionSettings.Disconnect();
        }
    }   


}
