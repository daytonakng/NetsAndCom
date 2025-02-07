using System.Reflection;
using System.Security.Cryptography;
using System.Windows;

namespace Lab1
{
    public partial class MainWindow : Window
    {
        Dictionary<char, string> utf8ToKoi8rDictionary = new Dictionary<char, string>
            {
                { '─', "128" },
                { '│', "129" },
                { '┌', "130" },
                { '┐', "131" },
                { '└', "132" },
                { '┘', "133" },
                { '├', "134" },
                { '┤', "135" },
                { '┬', "136" },
                { '┴', "137" },
                { '┼', "138" },
                { '▀', "139" },
                { '▄', "140" },
                { '█', "141" },
                { '▌', "142" },
                { '▐', "143" },
                { '░', "144" },
                { '▒', "145" },
                { '▓', "146" },
                { '⌠', "147" },
                { '■', "148" },
                { '∙', "149" },
                { '√', "150" },
                { '≈', "151" },
                { '≤', "152" },
                { '≥', "153" },
                { ' ', "154" },
                { '⌡', "155" },
                { '°', "156" },
                { '²', "157" },
                { '·', "158" },
                { '÷', "159" },
                { '═', "160" },
                { '║', "161" },
                { '╒', "162" },
                { 'ё', "163" },
                { '╓', "164" },
                { '╔', "165" },
                { '╕', "166" },
                { '╖', "167" },
                { '╗', "168" },
                { '╘', "169" },
                { '╙', "170" },
                { '╚', "171" },
                { '╛', "172" },
                { '╜', "173" },
                { '╝', "174" },
                { '╞', "175" },
                { '╟', "176" },
                { '╠', "177" },
                { '╡', "178" },
                { 'Ё', "179" },
                { '╢', "180" },
                { '╣', "181" },
                { '╤', "182" },
                { '╥', "183" },
                { '╦', "184" },
                { '╧', "185" },
                { '╨', "186" },
                { '╩', "187" },
                { '╪', "188" },
                { '╫', "189" },
                { '╬', "190" },
                { '©', "191" },
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
            };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void codeButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            string text = enterTextBox.Text;
            List<int> textArr = new List<int>();
            string binary = "";

            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char c = text[i];
                    if (!utf8ToKoi8rDictionary.ContainsKey(c))
                    {
                        resultTextBox.Clear();
                        MessageBox.Show($"Ошибка! Некоторые символы отсутствуют в словаре!");
                        break;
                    }
                    else
                    {
                        resultTextBox.Text += utf8ToKoi8rDictionary[c];
                        resultTextBox.Text += " ";
                        textArr.Add(int.Parse(utf8ToKoi8rDictionary[c]));
                        binary += Convert.ToString(int.Parse(utf8ToKoi8rDictionary[c]), 2);
                        binary += " ";

                        historyTextBox.Text += utf8ToKoi8rDictionary[c];
                        historyTextBox.Text += " ";
                    }
                }
            }
            catch (Exception)
            {
                resultTextBox.Clear();
                MessageBox.Show($"Ошибка! Некоторые символы отсутствуют в словаре!");
            }
            resultTextBox.Text += "\n";
            resultTextBox.Text += binary;

            historyTextBox.Text += "\n";
            historyTextBox.Text += binary;
            historyTextBox.Text += "\n\n";
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

            try
            {
                foreach (var value in textArr)
                {
                    if (!utf8ToKoi8rDictionary.ContainsValue(value))
                    {
                        resultTextBox.Clear();
                        MessageBox.Show($"Ошибка! Некоторые числа отсутствуют в словаре!");
                        break;

                    }
                    else
                    {
                        var key = utf8ToKoi8rDictionary.FirstOrDefault(x => x.Value == value).Key;
                        resultTextBox.Text += key;
                        historyTextBox.Text += key;
                    }
                }
                historyTextBox.Text += "\n\n";
            }
            catch (Exception)
            {
                resultTextBox.Clear();
                MessageBox.Show($"Ошибка! Некоторые числа отсутствуют в словаре!");
            }
        }
    }
}