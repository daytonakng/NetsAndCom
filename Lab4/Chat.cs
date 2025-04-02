using System.Net.Sockets;
using System.Text;

namespace Lab4
{
    public partial class Chat : Form
    {
        private int localPort;
        public string fileName;
        public string path;

        public Chat(string name, int local)
        {
            InitializeComponent();
            Name = name;
            localPort = local;

            fileName = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + ".txt";
            path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            File.Create(path).Close();
        }

        async Task ReceiveMessageAsync()
        {
            using UdpClient receiver = new UdpClient(localPort);

            try
            {
                while (true)
                {
                    var result = await receiver.ReceiveAsync();

                    UDPMessage receivedMessage = UDPMessage.Deserialize(result.Buffer);
                    if (receivedMessage.IsCheck)
                    {
                        UDPMessage response = new UDPMessage(true, "�������� ������� ��������!");
                        byte[] responseBytes = response.Serialize();
                        await receiver.SendAsync(responseBytes, responseBytes.Length, result.RemoteEndPoint);
                    }
                    else
                    {
                        if (receivedMessage.Length == receivedMessage.Message.Length)
                        {
                            string messageText = Encoding.UTF8.GetString(receivedMessage.Message);
                            chatBox.AppendText(messageText + Environment.NewLine);
                        }
                        else
                        {
                            chatBox.AppendText("��������� ����������!" + Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������� ����������: " + ex.Message + ex.StackTrace);
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            using UdpClient udpSender = new UdpClient();
            string inputMessage = messageBox.Text;

            int errorCount = 0;

            for (int i = 0; i < inputMessage.Length; i++)
            {
                char c = inputMessage[i];
                if (!utf8ToKoi8rDictionary.ContainsKey(c))
                {
                    errorCount++;
                }
            }
            if (errorCount > 0)
            {
                chatBox.Text = "������! ������� �������, ������������� � �������!\n";
            }
            else
            {
                string textBinStr = "";
                string textIntStr = "";

                for (int i = 0; i < inputMessage.Length; i++)
                {
                    char c = inputMessage[i];
                    textIntStr += $"{utf8ToKoi8rDictionary[c]} ";
                    textBinStr += $"{Convert.ToString(int.Parse(utf8ToKoi8rDictionary[c]), 2)} ";
                }

                string message = $"{Name}: {inputMessage}\n{textIntStr}\n{textBinStr}";

                UDPMessage newMessage = new UDPMessage(false, message);
                byte[] messageBytes = newMessage.Serialize();

                await udpSender.SendAsync(messageBytes, messageBytes.Length, ipTextBox.Text, int.Parse(remotePortTextBox.Text));
                chatBox.AppendText("��: " + inputMessage + Environment.NewLine);

                using (StreamWriter fstream = new StreamWriter(fileName, true))
                {
                    fstream.Write(message + Environment.NewLine);
                }

                messageBox.Clear();
            }
        }

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

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            _ = ReceiveMessageAsync();
        }
    }

    [Serializable]
    public class UDPMessage
    {
        public bool IsCheck { get; set; }
        public int Length { get; set; }
        public byte[] Message { get; set; }
        public UDPMessage(bool isCheck, string messageText)
        {
            IsCheck = isCheck;
            byte[] messageBytes = Encoding.UTF8.GetBytes(messageText);
            Message = messageBytes;
            Length = messageBytes.Length;
        }

        public UDPMessage() { }
        public byte[] Serialize()
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(IsCheck);
                    writer.Write(Length);
                    writer.Write(Message);
                }
                return m.ToArray();
            }
        }

        public static UDPMessage Deserialize(byte[] data)
        {
            UDPMessage result = new UDPMessage();
            using (MemoryStream m = new MemoryStream(data))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    result.IsCheck = reader.ReadBoolean();
                    result.Length = reader.ReadInt32();
                    result.Message = reader.ReadBytes(data.Length - sizeof(bool) - sizeof(int));
                }
            }
            return result;
        }
    }
}
