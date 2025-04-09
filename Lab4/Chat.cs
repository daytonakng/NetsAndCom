using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Lab4
{
    public partial class Chat : Form
    {
        private int localPort;
        public string fileName;
        public string path;

        public bool checkConn = true;

        public Chat(string name, int local)
        {
            InitializeComponent();
            Name = name;
            localPort = local;

            fileName = DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + ".txt";
            path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            File.Create(path).Close();
        }

        private async void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient senderMess = new UdpClient();
                string test = "Тест";
                byte[] messBytes = Encoding.UTF8.GetBytes(test);

                UDPMessage check = new UDPMessage(true, messBytes);
                string checkString = JsonSerializer.Serialize(check);
                byte[] checkStringBytes = Encoding.UTF8.GetBytes(checkString);

                await senderMess.SendAsync(checkStringBytes, checkStringBytes.Length, ipTextBox.Text, int.Parse(remotePortTextBox.Text));

                checkButton.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникло исключение при проверке соединения:\n" + ex.Message + ex.StackTrace);
            }
        }

        async Task ReceiveMessageAsync()
        {
            using UdpClient receiver = new UdpClient(localPort);

            try
            {
                while (true)
                {
                    var result = await receiver.ReceiveAsync();
                    string jsonString = Encoding.UTF8.GetString(result.Buffer);
                    UDPMessage receivedMessage = JsonSerializer.Deserialize<UDPMessage>(jsonString);

                    if (checkConn)
                    {
                        if (receivedMessage.IsCheck)
                        {
                            string responseString = "Проверка пройдена";
                            byte[] responseBytes = Encoding.UTF8.GetBytes(responseString);

                            UDPMessage checkRes = new UDPMessage(false, responseBytes);
                            string checkResString = JsonSerializer.Serialize(checkRes);
                            byte[] checkResBytes = Encoding.UTF8.GetBytes(checkResString);

                            await receiver.SendAsync(checkResBytes, checkResBytes.Length, ipTextBox.Text, int.Parse(remotePortTextBox.Text));
                        }

                        if (Encoding.UTF8.GetString(receivedMessage.Message) == "Проверка пройдена")
                        {
                            MessageBox.Show("Проверка успешно пройдена");
                            checkConn = false;
                        }
                    }

                    if (receivedMessage.Length == receivedMessage.Message.Length)
                    {
                        string messageText = Encoding.UTF8.GetString(receivedMessage.Message);
                        chatBox.AppendText(messageText + Environment.NewLine);
                    }
                    else
                    {
                        chatBox.AppendText("Сообщение повреждено!" + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение при получении сообщения\n" + ex.Message + ex.StackTrace);
            }
        }

        private async void SendMessage()
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
                chatBox.Text = "Ошибка! Найдены символы, отсутствующие в словаре!\n";
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
                try
                {
                    string message = $"{Name}: {inputMessage}\n{textIntStr}\n{textBinStr}";
                    byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                    UDPMessage newMessage = new UDPMessage(true, messageBytes);

                    string messageString = JsonSerializer.Serialize(newMessage);
                    byte[] messageStringBytes = Encoding.UTF8.GetBytes(messageString);

                    await udpSender.SendAsync(messageStringBytes, messageStringBytes.Length, ipTextBox.Text, int.Parse(remotePortTextBox.Text));
                    chatBox.AppendText("Вы: " + inputMessage + Environment.NewLine);

                    using (StreamWriter fstream = new StreamWriter(fileName, true))
                    {
                        fstream.Write(message + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникло исключение при отправке сообщения\n" + ex.Message + ex.StackTrace);
                }

                messageBox.Clear();
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
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
                { 'ю', "192" },
                { 'а', "193" },
                { 'б', "194" },
                { 'ц', "195" },
                { 'д', "196" },
                { 'е', "197" },
                { 'ф', "198" },
                { 'г', "199" },
                { 'х', "200" },
                { 'и', "201" },
                { 'й', "202" },
                { 'к', "203" },
                { 'л', "204" },
                { 'м', "205" },
                { 'н', "206" },
                { 'о', "207" },
                { 'п', "208" },
                { 'я', "209" },
                { 'р', "210" },
                { 'с', "211" },
                { 'т', "212" },
                { 'у', "213" },
                { 'ж', "214" },
                { 'в', "215" },
                { 'ь', "216" },
                { 'ы', "217" },
                { 'з', "218" },
                { 'ш', "219" },
                { 'э', "220" },
                { 'щ', "221" },
                { 'ч', "222" },
                { 'ъ', "223" },
                { 'Ю', "224" },
                { 'А', "225" },
                { 'Б', "226" },
                { 'Ц', "227" },
                { 'Д', "228" },
                { 'Е', "229" },
                { 'Ф', "230" },
                { 'Г', "231" },
                { 'Х', "232" },
                { 'И', "233" },
                { 'Й', "234" },
                { 'К', "235" },
                { 'Л', "236" },
                { 'М', "237" },
                { 'Н', "238" },
                { 'О', "239" },
                { 'П', "240" },
                { 'Я', "241" },
                { 'Р', "242" },
                { 'С', "243" },
                { 'Т', "244" },
                { 'У', "245" },
                { 'Ж', "246" },
                { 'В', "247" },
                { 'Ь', "248" },
                { 'Ы', "249" },
                { 'З', "250" },
                { 'Ш', "251" },
                { 'Э', "252" },
                { 'Щ', "253" },
                { 'Ч', "254" },
                { 'Ъ', "255" },
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
                { '№', "268" },
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

        public UDPMessage(bool isCheck, byte[] messageBytes)
        {
            IsCheck = isCheck;
            Message = messageBytes;
            Length = messageBytes.Length;
        }

        public UDPMessage() { }
    }
}
