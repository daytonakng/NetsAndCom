using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Lab3ServerWF
{
    public partial class ServerForm : Form
    {
        private TcpListener listener;
        private Thread listenThread;
        private List<TcpClient> clients = new List<TcpClient>();

        public string fileName;
        public string path;

        public ServerForm()
        {
            InitializeComponent();

            fileName = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + ".txt";
            path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            File.Create(path).Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(serverIpTextBox.Text);
                int port = int.Parse(serverPortTextBox.Text);
                listener = new TcpListener(ip, port);
                listener.Start();

                listenThread = new Thread(ListenForClients);
                listenThread.Start();

                serverBox.AppendText("Сервер запущен и ожидает подключений\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запуска сервера:\n{ex.Message}\n{ex.StackTrace}");
            }
        }

        private void ListenForClients()
        {
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(client);
            }
        }

        private void HandleClient(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytes;

            while ((bytes = stream.Read(buffer, 0, buffer.Length)) != 0)
            {
                string data = Encoding.UTF8.GetString(buffer, 0, bytes);
                serverBox.Invoke((MethodInvoker)delegate { serverBox.AppendText($"{data}\n"); });

                byte[] response = Encoding.UTF8.GetBytes(data);
                foreach (var clientItem in clients)
                {
                    if (clientItem != client)
                    {
                        clientItem.GetStream().Write(response, 0, response.Length);
                    }
                }

                using (StreamWriter fstream = new StreamWriter(fileName, true))
                {
                    fstream.Write(data + Environment.NewLine);
                }
            }

            client.Close();
        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            Left = 800;
            Top = 200;
        }
    }
}
