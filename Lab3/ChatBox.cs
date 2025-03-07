using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Lab3
{
    public partial class ChatBox : Form
    {
        private TcpClient client;
        public StreamReader str { get; set; }
        public StreamWriter stw { get; set; }
        public string recieve;
        public string textToSend;

        public string fileClientName;
        public string fileServerName;
        public string pathClient;
        public string pathServer;

        Dictionary<char, string> utf8ToKoi8rDictionary = new Dictionary<char, string>
            {
                { 'a', "128" },
                { 'b', "129" },
                { 'c', "130" },
                { 'd', "131" },
                { 'e', "132" },
                { 'f', "133" },
                { 'g', "134" },
                { 'h', "135" },
                { 'i', "136" },
                { 'j', "137" },
                { 'k', "138" },
                { 'l', "139" },
                { 'm', "140" },
                { 'n', "141" },
                { 'o', "142" },
                { 'p', "143" },
                { 'q', "144" },
                { 'r', "145" },
                { 's', "146" },
                { 't', "147" },
                { 'u', "148" },
                { 'v', "149" },
                { 'w', "150" },
                { 'x', "151" },
                { 'y', "152" },
                { 'z', "153" },
                { 'A', "154" },
                { 'B', "155" },
                { 'C', "156" },
                { 'D', "157" },
                { 'E', "158" },
                { 'F', "159" },
                { 'G', "160" },
                { 'H', "161" },
                { 'I', "162" },
                { 'J', "163" },
                { 'K', "164" },
                { 'L', "165" },
                { 'M', "166" },
                { 'N', "167" },
                { 'O', "168" },
                { 'P', "169" },
                { 'Q', "170" },
                { 'R', "171" },
                { 'S', "172" },
                { 'T', "173" },
                { 'U', "174" },
                { 'V', "175" },
                { 'W', "176" },
                { 'X', "177" },
                { 'Y', "178" },
                { 'Z', "179" },
                { '0', "180" },
                { '1', "181" },
                { '2', "182" },
                { '3', "183" },
                { '4', "184" },
                { '5', "185" },
                { '6', "186" },
                { '7', "187" },
                { '8', "188" },
                { '9', "189" },
                { ' ', "190" },
                { '.', "191" },
                { '�', "192" },
                { '�', "193" },
                { '�', "194" },
                { '�', "195" },
                { '�', "196" },
                { '�', "197" },
                { '�', "198" },
                { '�', "199" },
                { '�', "200" },
                { '�', "201" },
                { '�', "202" },
                { '�', "203" },
                { '�', "204" },
                { '�', "205" },
                { '�', "206" },
                { '�', "207" },
                { '�', "208" },
                { '�', "209" },
                { '�', "210" },
                { '�', "211" },
                { '�', "212" },
                { '�', "213" },
                { '�', "214" },
                { '�', "215" },
                { '�', "216" },
                { '�', "217" },
                { '�', "218" },
                { '�', "219" },
                { '�', "220" },
                { '�', "221" },
                { '�', "222" },
                { '�', "223" },
                { '�', "224" },
                { '�', "225" },
                { '�', "226" },
                { '�', "227" },
                { '�', "228" },
                { '�', "229" },
                { '�', "230" },
                { '�', "231" },
                { '�', "232" },
                { '�', "233" },
                { '�', "234" },
                { '�', "235" },
                { '�', "236" },
                { '�', "237" },
                { '�', "238" },
                { '�', "239" },
                { '�', "240" },
                { '�', "241" },
                { '�', "242" },
                { '�', "243" },
                { '�', "244" },
                { '�', "245" },
                { '�', "246" },
                { '�', "247" },
                { '�', "248" },
                { '�', "249" },
                { '�', "250" },
                { '�', "251" },
                { '�', "252" },
                { '�', "253" },
                { '�', "254" },
                { '�', "255" },
                { '?', "256" },
                { '!', "257" },
                { ',', "258" },
                { ';', "259" },
                { ':', "260" },
                { '-', "261" },
                { '+', "262" },
                { '=', "263" },
                { '@', "264" },
                { '*', "265" },
                { '/', "266" },
                { '#', "267" },
                { '�', "268" },
                { '(', "269" },
                { ')', "270" },
                { '[', "271" },
                { ']', "272" },
                { '{', "273" },
                { '}', "274" }
            };

        public ChatBox()
        {
            InitializeComponent();

            fileClientName = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + "_client.txt";
            pathClient = Path.Combine(Directory.GetCurrentDirectory(), fileClientName);
            File.Create(pathClient).Close();

            //fileServerName = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + "_server.txt";
            //pathServer = Path.Combine(Directory.GetCurrentDirectory(), fileServerName);
            //File.Create(pathServer).Close();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIpTextBox.Text = address.ToString();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(serverPortTextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;
            chatTCPBox.AppendText("������ �������" + Environment.NewLine);

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(clientIpTextBox.Text), int.Parse(clientPortTextBox.Text));

            try
            {
                client.Connect(ipEnd);
                chatTCPBox.AppendText("���������� �����������" + Environment.NewLine);
                str = new StreamReader(client.GetStream());
                stw = new StreamWriter(client.GetStream());
                stw.AutoFlush = true;

                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ � �����������!" + "\n" + ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = str.ReadLine();
                    this.chatTCPBox.Invoke(new MethodInvoker(delegate ()
                    {
                        chatTCPBox.AppendText(recieve + Environment.NewLine);
                    }
                    ));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ � ������ backGroundWorker1!" + "\n" + ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(textToSend);
                this.chatTCPBox.Invoke(new MethodInvoker(delegate ()
                {
                    chatTCPBox.AppendText(textToSend + Environment.NewLine);
                    using (StreamWriter fstream = new StreamWriter(fileClientName, true))   
                    {
                        fstream.Write(textToSend + Environment.NewLine);
                    }
                }
                ));
            }
            else
            {
                MessageBox.Show("������ �������� ���������! ������ �� ���������!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (name != "")
            {
                if (messageBox.Text != "")
                {
                    string text = messageBox.Text;

                    int errorCount = 0;

                    for (int i = 0; i < text.Length; i++)
                    {
                        char c = text[i];
                        if (!utf8ToKoi8rDictionary.ContainsKey(c))
                        {
                            errorCount++;
                        }
                    }
                    if (errorCount > 0)
                    {
                        chatTCPBox.Text = "������! ������� �������, ������������� � �������!\n";
                    }
                    else
                    {
                        string textBinStr = "";
                        string textIntStr = "";

                        for (int i = 0; i < text.Length; i++)
                        {
                            char c = text[i];
                            textIntStr += $"{utf8ToKoi8rDictionary[c]} ";
                            textBinStr += $"{Convert.ToString(int.Parse(utf8ToKoi8rDictionary[c]), 2)} ";
                        }
                        textToSend = "";
                        textToSend += $"{name}: {text} {textIntStr} {textBinStr}\n";
                        backgroundWorker2.RunWorkerAsync();
                    }
                }
                messageBox.Text = "";
            }
            else
            {
                MessageBox.Show("��� ������������ �� ������!");
            }
        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            string name = nameTextBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (name != "")
                {
                    if (messageBox.Text != "")
                    {
                        string text = messageBox.Text;

                        int errorCount = 0;

                        for (int i = 0; i < text.Length; i++)
                        {
                            char c = text[i];
                            if (!utf8ToKoi8rDictionary.ContainsKey(c))
                            {
                                errorCount++;
                            }
                        }
                        if (errorCount > 0)
                        {
                            chatTCPBox.Text = "������! ������� �������, ������������� � �������!\n";
                        }
                        else
                        {
                            string textBinStr = "";
                            string textIntStr = "";

                            for (int i = 0; i < text.Length; i++)
                            {
                                char c = text[i];
                                textIntStr += $"{utf8ToKoi8rDictionary[c]} ";
                                textBinStr += $"{Convert.ToString(int.Parse(utf8ToKoi8rDictionary[c]), 2)} ";
                            }
                            textToSend = "";
                            textToSend += $"{name}: {text} {textIntStr} {textBinStr}\n";
                            backgroundWorker2.RunWorkerAsync();
                        }
                    }
                    messageBox.Text = "";
                }
                else
                {
                    MessageBox.Show("��� ������������ �� ������!");
                }
            }
        }

        private void ChatBox_Load(object sender, EventArgs e)
        {
            mainPanel.Enabled = false;
        }

        private void serverRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton serverRB = (RadioButton)sender;
            if (serverRB.Checked)
            {
                mainPanel.Enabled = true;
                clientPanel.Enabled = false;
                serverPanel.Enabled = true;
            }
        }

        private void clientRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clientRB = (RadioButton)sender;
            if (clientRB.Checked)
            {
                mainPanel.Enabled = true;
                serverPanel.Enabled = false;
                clientPanel.Enabled = true;
            }
        }
    }
}
