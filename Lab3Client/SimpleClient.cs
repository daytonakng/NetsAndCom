using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Console
{
    public class SimpleClient
    {
        private TcpClient client;
        private NetworkStream stream;

        public void ConnectToServer(string ipAddress, int port)
        {
            client = new TcpClient(ipAddress, port);
            stream = client.GetStream();
            Console.WriteLine("Подключено к серверу.");

            ReadMessages();
        }

        private void ReadMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Сервер пишет: " + message);
            }
        }

        public void SendMessage(string message)
        {
            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Сообщение отправлено: " + message);
            }
        }
    }
}
