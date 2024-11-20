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
                return customMessageBox.Continue; // Возвращаем результат, чтобы определить, продолжать или прервать
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
                    int i = c - 'a'; // Номер символа в алфавите
                    int encryptedIndex = (i * k1 + k0) % n; // Применяем шифрование
                    ciphertext += (char)('a' + encryptedIndex); // Добавляем зашифрованный символ
                }
                else
                {
                    ciphertext += c; // Добавляем символы, которые не являются буквами нижнего регистра
                }
            }

            return ciphertext;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string information = InformationtextBox.Text.ToString();
            int k0, k1, n;

            // Проверка ввода k0
            if (!int.TryParse(K0textBox.Text, out k0))
            {
                ShowCustomMessage("Некорректный ввод k0");
                return;
            }

            // Проверка ввода k1
            if (!int.TryParse(K1textBox.Text, out k1))
            {
                ShowCustomMessage("Некорректный ввод k1");
                return;
            }

            // Проверка ввода n
            if (!int.TryParse(NtextBox1.Text, out n))
            {
                ShowCustomMessage("Некорректный ввод n");
                return;
            }

            // Проверка взаимной простоты k1 и n
            if (!AreCoprime(k1, n))
            {
                if (!ShowCustomMessage("k1 и n должны быть взаимно простыми!"))
                    return; // Прервать выполнение, если пользователь нажал "Прервать"
            }

            // Проверка корректности значения n
            if (!(n == 26 || n == 256))
            {
                if (!ShowCustomMessage("Некорректный ввод n. Должно быть 26 либо 256"))
                    return; // Прервать выполнение, если пользователь нажал "Прервать"
            }

            // Выполнение шифрования
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
            // Английский алфавит
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

            // Словарь для хранения количества каждой буквы
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
                if (char.IsLetter(c)) // Проверяем, является ли символ буквой
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

            // Найти сдвиг
            int shift = FindShift(englishFrequencies, letterCount, length);

            // Дешифрование текста с найденным сдвигом
            string decryptedText = DecryptCaesar(input, shift);
            EncrypttextBox1.Clear();
            EncrypttextBox1.AppendText($"Предполагаемый сдвиг: {shift}\n");
            EncrypttextBox1.AppendText($"Расшифрованный текст: \n{decryptedText}\n");

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
            EncrypttextBox1.AppendText($"Предполагаемый сдвиг: {shift}\n");
            EncrypttextBox1.AppendText($"Расшифрованный текст: \n{encryptedText}\n");
        }

    }
}