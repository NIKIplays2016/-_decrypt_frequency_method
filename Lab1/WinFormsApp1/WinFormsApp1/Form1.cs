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
                if (char.IsLetter(c) || (n == 256 && c < 256))
                {
                    char baseChar = (n == 26) ? (char)(char.IsLower(c) ? 'a' : 'A') : (char)0;
                    int i = (n == 26) ? (c - baseChar) : c; // Номер символа в алфавите или ASCII
                    int encryptedIndex = (i * k1 + k0) % n; // Применяем шифрование
                    ciphertext += (char)(baseChar + encryptedIndex); // Добавляем зашифрованный символ
                }
                else
                {
                    ciphertext += c; // Добавляем символы, которые не являются буквами или ASCII
                }
            }

            return ciphertext;
        }
        static string Decrypt(string encrypt_text, int k0, int k1, int n)
        {
            string plaintext = "";

            // Находим мультипликативную обратную k1
            int k1Inverse = -1;
            for (int i = 1; i < n; i++)
            {
                if ((k1 * i) % n == 1)
                {
                    k1Inverse = i;
                    break;
                }
            }

            if (k1Inverse == -1)
            {
                MessageBox.Show("k1 не имеет обратного значения по модулю n.");
            }

            foreach (char c in encrypt_text)
            {
                if (char.IsLetter(c) || (n == 256 && c < 256))
                {
                    char baseChar = (n == 26) ? (char)(char.IsLower(c) ? 'a' : 'A') : (char)0;
                    int i = (n == 26) ? (c - baseChar) : c; // Номер символа в алфавите или ASCII
                    int decryptedIndex = (k1Inverse * (i - k0 + n)) % n; // Применяем дешифрование
                    plaintext += (char)(baseChar + decryptedIndex); // Добавляем расшифрованный символ
                }
                else
                {
                    plaintext += c; // Добавляем символы, которые не являются буквами или ASCII
                }
            }

            return plaintext;
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
            string ciphertext = Encrypt(information, k0, k1, n);
            EncrypttextBox0.Text = ciphertext;
            EncrypttextBox0.ReadOnly = true;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string encrypt_text = EncrypttextBox1.Text.ToString();
            int k0, k1, n;

            // Проверка ввода k0
            if (!int.TryParse(K0textBox1.Text, out k0))
            {
                ShowCustomMessage("Некорректный ввод k0");
                return;
            }

            // Проверка ввода k1
            if (!int.TryParse(K1textBox1.Text, out k1))
            {
                ShowCustomMessage("Некорректный ввод k1");
                return;
            }

            // Проверка ввода n
            if (!int.TryParse(NtextBox2.Text, out n))
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

            // Выполнение дешифрования
            string decrypt_text = Decrypt(encrypt_text, k0, k1, n);
            EncrypttextBox.Text = decrypt_text;
            EncrypttextBox.ReadOnly = true;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            EncrypttextBox1.Text = EncrypttextBox0.Text.ToString();
            EncrypttextBox1.ReadOnly = true;
            EncrypttextBox0.ReadOnly = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            EncrypttextBox0.ReadOnly = false;
            EncrypttextBox1 .ReadOnly = false;
            EncrypttextBox.ReadOnly = false;
            InformationtextBox.ReadOnly = false;
            InformationtextBox.Clear();
            EncrypttextBox1.Clear();
            EncrypttextBox0.Clear();
            EncrypttextBox.Clear();
            K0textBox.Clear();
            K1textBox.Clear();
            K0textBox1.Clear();
            K1textBox1.Clear();
            NtextBox1.Clear();
            NtextBox2.Clear();
        }
    }
}