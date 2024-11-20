namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ShowCustomMessage(string message)
        {
            using (var customMessageBox = new CustomMessageBox(message))
            {
                customMessageBox.ShowDialog();
                return customMessageBox.Continue; // ���������� ���������, ����� ����������, ���������� ��� ��������
            }
        }
        static bool AreCoprime(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }

        static string Encrypt(string plaintext, int k0, int k1, int n)
        {
            string ciphertext = "";

            foreach (char c in plaintext)
            {
                if (char.IsLower(c) && n == 26)
                {
                    int i = c - 'a'; // ����� ������� � ��������
                    int encryptedIndex = (i * k1 + k0) % n; // ��������� ����������
                    ciphertext += (char)('a' + encryptedIndex); // ��������� ������������� ������
                }
                else
                {
                    ciphertext += c; // ��������� �������, ������� �� �������� ������� ������� ��������
                }
            }

            return ciphertext;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string information = InformationtextBox.Text.ToString();
            int k0, k1, n;

            // �������� ����� k0
            if (!int.TryParse(K0textBox.Text, out k0))
            {
                ShowCustomMessage("������������ ���� k0");
                return;
            }

            // �������� ����� k1
            if (!int.TryParse(K1textBox.Text, out k1))
            {
                ShowCustomMessage("������������ ���� k1");
                return;
            }

            // �������� ����� n
            if (!int.TryParse(NtextBox1.Text, out n))
            {
                ShowCustomMessage("������������ ���� n");
                return;
            }

            // �������� �������� �������� k1 � n
            if (!AreCoprime(k1, n))
            {
                if (!ShowCustomMessage("k1 � n ������ ���� ������� ��������!"))
                    return; // �������� ����������, ���� ������������ ����� "��������"
            }

            // �������� ������������ �������� n
            if (!(n == 26 || n == 256))
            {
                if (!ShowCustomMessage("������������ ���� n. ������ ���� 26 ���� 256"))
                    return; // �������� ����������, ���� ������������ ����� "��������"
            }

            // ���������� ����������
            string ciphertext = Encrypt(information.ToLower(), k0, k1, n);
            EncrypttextBox0.Text = ciphertext;
            EncrypttextBox0.ReadOnly = true;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            EncrypttextBox0.ReadOnly = false;
            EncrypttextBox1.ReadOnly = false;
            InformationtextBox.ReadOnly = false;
            InformationtextBox.Clear();
            EncrypttextBox1.Clear();
            EncrypttextBox0.Clear();
            K0textBox.Clear();
            K1textBox.Clear();
            NtextBox1.Clear();

        }

        private int FindShift(Dictionary<char, double> languageFrequencies, Dictionary<char, int> letterCount, int textLength)
        {
            double minDifference = double.MaxValue;
            int bestShift = 0;

            for (int shift = 0; shift < 26; shift++)
            {
                double totalDifference = 0;

                foreach (var pair in languageFrequencies)
                {
                    char shiftedChar = (char)((pair.Key - 'a' + shift) % 26 + 'a');
                    double observedFrequency = letterCount.ContainsKey(shiftedChar) ? (double)letterCount[shiftedChar] / textLength : 0;
                    totalDifference += Math.Abs(pair.Value - observedFrequency);
                }

                if (totalDifference < minDifference)
                {
                    minDifference = totalDifference;
                    bestShift = shift;
                }
            }


            return bestShift;
        }

        private void hack_text(object sender, EventArgs e)
        {
            double frequency;
            // ���������� �������
            Dictionary<char, double> englishFrequencies = new Dictionary<char, double>
    {
        {'e', 12.31}, {'t', 9.59}, {'a', 8.05}, {'o', 7.94}, {'n', 7.19},
        {'i', 7.18}, {'s', 6.59}, {'r', 6.03}, {'l', 4.03},
        {'d', 3.65}, {'c', 3.20}, {'u', 3.10}, {'p', 2.29}, {'f', 2.28},
        {'w', 2.03}, {'y', 1.88}, {'b', 1.62}, {'g', 1.61},
        {'v', 0.93}, {'k', 0.52}, {'q', 0.20}, {'x', 0.20}, {'j', 0.10}, {'z', 0.09}
    };

            string input = EncrypttextBox0.Text.ToLower();
            int length = input.Length;

            // ������� ��� �������� ���������� ������ �����
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            int new_str = 0;
            foreach (var pair in englishFrequencies)
            {
                 new_str++;
                 richTextBox2.AppendText($"  {pair.Key} - {pair.Value}  ");
                 if (new_str % 3 == 0)
                 {
                     richTextBox2.AppendText("\n");
                 }
            }

            foreach (char c in input)
            {
                if (char.IsLetter(c)) // ���������, �������� �� ������ ������
                {
                    if (letterCount.ContainsKey(c))
                    {
                        letterCount[c]++;
                    }
                    else
                    {
                        letterCount[c] = 1;
                    }
                }
            }

            // ����� �����
            int shift = FindShift(englishFrequencies, letterCount, length);

            // ������������ ������ � ��������� �������
            string decryptedText = DecryptCaesar(input, shift);
            EncrypttextBox1.Clear();
            EncrypttextBox1.AppendText($"�������������� �����: {shift}\n");
            EncrypttextBox1.AppendText($"�������������� �����: \n{decryptedText}\n");

            new_str = 0;
            foreach (var pair in letterCount)
            {
                new_str++;
                frequency = Math.Round(((double)pair.Value / length) * 100, 1);
                richTextBox1.AppendText($"  {pair.Key} - {frequency}  ");
                if (new_str % 3 == 0)
                {
                    richTextBox1.AppendText("\n");
                }
            }

            
        }

        private string DecryptCaesar(string input, int shift)
        {
            string result = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char decryptedChar = (char)((c - 'a' - shift + 26) % 26 + 'a');
                    result += decryptedChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        private void check_shift(object sender, EventArgs e)
        {
            int shift = shiftTextBox.Text == "" ? 0 : int.Parse(shiftTextBox.Text);

            string encryptedText = DecryptCaesar(EncrypttextBox0.Text.ToLower(), shift);
            EncrypttextBox1.Clear();
            EncrypttextBox1.AppendText($"�������������� �����: {shift}\n");
            EncrypttextBox1.AppendText($"�������������� �����: \n{encryptedText}\n");
        }

    }
}