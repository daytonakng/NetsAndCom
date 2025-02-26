using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows;

namespace Lab2
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private UdpClient udpClient;
        private int localPort;
        private int remotePort;
        private IPEndPoint remoteEndPoint;
        private IPAddress remoteIp;

        async void StartListener()
        {
            localPort = Convert.ToInt16(localPortTextBox.Text);
            remotePort = Convert.ToInt16(remotePortTextBox.Text);
            remoteIp = IPAddress.Parse(ipTextBox.Text);

            udpClient = new UdpClient(localPort);
            remoteEndPoint = new IPEndPoint(remoteIp, remotePort);
            try
            {
                while (true)
                {
                    var receivedResults = await udpClient.ReceiveAsync();
                    string receivedMessage = Encoding.UTF8.GetString(receivedResults.Buffer);
                    //Dispatcher.Invoke(() => { resultTextBox.AppendText($"{receivedMessage}\n"); });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void sendButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string message = messageBox.Text;

        //    var local = new IPEndPoint(remoteEndPoint.Address, localPort);
        //    UdpClient remoteUDpClient = new UdpClient();

        //    if (!string.IsNullOrWhiteSpace(message))
        //    {
        //        var data = Encoding.UTF8.GetBytes(message);
        //        remoteUDpClient.Send(data, data.Length, local);
        //        messageBox.Clear();
        //    }
        //    else
        //    {
        //        MessageBox.Show("������! ������� ��� �(���) ���������");
        //    }
        //}

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

        private void Encode()
        {
            chatBox.Clear();
            string text = messageBox.Text;
            List<int> textArr = new List<int>();
            string binary = "";
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
                chatBox.Text = "������! ������� �������, ������������� � �������!";
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char c = text[i];
                    chatBox.Text += utf8ToKoi8rDictionary[c];
                    chatBox.Text += " ";
                    textArr.Add(int.Parse(utf8ToKoi8rDictionary[c]));
                    binary += Convert.ToString(int.Parse(utf8ToKoi8rDictionary[c]), 2);
                    binary += " ";
                }
                chatBox.Text += "\n";
                chatBox.Text += binary;
                chatBox.Text += "\n\n";
            }
        }
    }
}
