using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Lab3Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SimpleServer server = new SimpleServer();
            server.Start(5000);
        }
    }
}
