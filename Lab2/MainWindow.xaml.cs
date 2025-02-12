using System.Reflection;
using System.Security.Cryptography;
using System.Windows;

namespace Lab2
{
    public partial class MainWindow : Window
    {
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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void codeButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            string text = enterTextBox.Text;
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
                resultTextBox.Text = "Ошибка! Найдены символы, отсутствующие в словаре!";
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char c = text[i];
                    resultTextBox.Text += utf8ToKoi8rDictionary[c];
                    resultTextBox.Text += " ";
                    textArr.Add(int.Parse(utf8ToKoi8rDictionary[c]));
                    binary += Convert.ToString(int.Parse(utf8ToKoi8rDictionary[c]), 2);
                    binary += " ";
                }
                resultTextBox.Text += "\n";
                resultTextBox.Text += binary;
                resultTextBox.Text += "\n\n";

                historyTextBox.Text += resultTextBox.Text;
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            historyTextBox.Clear();
        }

        private void decodeButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            string text = enterTextBox.Text;
            List<string> textArr = [.. text.Split()];
            int errorCount = 0;

            foreach (var value in textArr)
            {
                if (!utf8ToKoi8rDictionary.ContainsValue(value))
                {
                    errorCount++;
                }
            }
            if (errorCount > 0)
            {
                resultTextBox.Text = "Ошибка! Найдены цифры, отсутствующие в словаре!";
            }
            else
            {
                foreach (var value in textArr)
                {
                    var key = utf8ToKoi8rDictionary.FirstOrDefault(x => x.Value == value).Key;
                    resultTextBox.Text += key;
                }
                historyTextBox.Text += resultTextBox.Text;
            }
        }
    }
}