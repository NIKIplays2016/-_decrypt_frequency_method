namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextEncription = new Label();
            TextDecipher = new Label();
            labelInformation = new Label();
            labelK0 = new Label();
            labelK1 = new Label();
            buttonEncrypt = new Button();
            labelDecrypt1 = new Label();
            button2 = new Button();
            labelDecrypt2 = new Label();
            K1textBox = new TextBox();
            K0textBox = new TextBox();
            buttonClear = new Button();
            NtextBox1 = new TextBox();
            labelN1 = new Label();
            EncrypttextBox0 = new RichTextBox();
            InformationtextBox = new RichTextBox();
            EncrypttextBox1 = new RichTextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            shiftTextBox = new TextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // TextEncription
            // 
            TextEncription.AutoSize = true;
            TextEncription.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextEncription.Location = new Point(21, 9);
            TextEncription.Name = "TextEncription";
            TextEncription.Size = new Size(314, 55);
            TextEncription.TabIndex = 0;
            TextEncription.Text = "Шифрование";
            // 
            // TextDecipher
            // 
            TextDecipher.AutoSize = true;
            TextDecipher.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextDecipher.Location = new Point(929, 9);
            TextDecipher.Name = "TextDecipher";
            TextDecipher.Size = new Size(358, 55);
            TextDecipher.TabIndex = 1;
            TextDecipher.Text = "Дешифрование";
            // 
            // labelInformation
            // 
            labelInformation.AutoSize = true;
            labelInformation.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInformation.Location = new Point(10, 69);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(218, 31);
            labelInformation.TabIndex = 2;
            labelInformation.Text = "Исходный текст:";
            // 
            // labelK0
            // 
            labelK0.AutoSize = true;
            labelK0.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelK0.Location = new Point(13, 344);
            labelK0.Name = "labelK0";
            labelK0.Size = new Size(164, 31);
            labelK0.TabIndex = 3;
            labelK0.Text = "Введите K0:";
            // 
            // labelK1
            // 
            labelK1.AutoSize = true;
            labelK1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelK1.Location = new Point(12, 379);
            labelK1.Name = "labelK1";
            labelK1.Size = new Size(164, 31);
            labelK1.TabIndex = 4;
            labelK1.Text = "Введите K1:";
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEncrypt.Location = new Point(12, 423);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(175, 50);
            buttonEncrypt.TabIndex = 5;
            buttonEncrypt.Text = "Шифровать";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // labelDecrypt1
            // 
            labelDecrypt1.AutoSize = true;
            labelDecrypt1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDecrypt1.Location = new Point(430, 69);
            labelDecrypt1.Name = "labelDecrypt1";
            labelDecrypt1.Size = new Size(303, 31);
            labelDecrypt1.TabIndex = 6;
            labelDecrypt1.Text = "Зашифрованный текст:";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 20.25F);
            button2.Location = new Point(695, 332);
            button2.Name = "button2";
            button2.Size = new Size(154, 41);
            button2.TabIndex = 7;
            button2.Text = "Взломать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += hack_text;
            // 
            // labelDecrypt2
            // 
            labelDecrypt2.AutoSize = true;
            labelDecrypt2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDecrypt2.Location = new Point(892, 69);
            labelDecrypt2.Name = "labelDecrypt2";
            labelDecrypt2.Size = new Size(251, 31);
            labelDecrypt2.TabIndex = 8;
            labelDecrypt2.Text = "Взломанный текст:";
            // 
            // K1textBox
            // 
            K1textBox.Location = new Point(182, 387);
            K1textBox.Name = "K1textBox";
            K1textBox.Size = new Size(68, 23);
            K1textBox.TabIndex = 15;
            // 
            // K0textBox
            // 
            K0textBox.Location = new Point(183, 350);
            K0textBox.Name = "K0textBox";
            K0textBox.Size = new Size(68, 23);
            K0textBox.TabIndex = 16;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Times New Roman", 20.25F);
            buttonClear.Location = new Point(430, 332);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(154, 41);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // NtextBox1
            // 
            NtextBox1.Location = new Point(163, 318);
            NtextBox1.Name = "NtextBox1";
            NtextBox1.Size = new Size(68, 23);
            NtextBox1.TabIndex = 24;
            // 
            // labelN1
            // 
            labelN1.AutoSize = true;
            labelN1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelN1.Location = new Point(13, 311);
            labelN1.Name = "labelN1";
            labelN1.Size = new Size(144, 31);
            labelN1.TabIndex = 23;
            labelN1.Text = "Введите n:";
            // 
            // EncrypttextBox0
            // 
            EncrypttextBox0.Location = new Point(430, 113);
            EncrypttextBox0.Name = "EncrypttextBox0";
            EncrypttextBox0.Size = new Size(419, 193);
            EncrypttextBox0.TabIndex = 27;
            EncrypttextBox0.Text = "";
            // 
            // InformationtextBox
            // 
            InformationtextBox.Location = new Point(10, 113);
            InformationtextBox.Name = "InformationtextBox";
            InformationtextBox.Size = new Size(394, 193);
            InformationtextBox.TabIndex = 28;
            InformationtextBox.Text = "";
            // 
            // EncrypttextBox1
            // 
            EncrypttextBox1.Location = new Point(901, 113);
            EncrypttextBox1.Name = "EncrypttextBox1";
            EncrypttextBox1.Size = new Size(373, 193);
            EncrypttextBox1.TabIndex = 29;
            EncrypttextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(901, 432);
            label1.Name = "label1";
            label1.Size = new Size(522, 62);
            label1.TabIndex = 30;
            label1.Text = "Таблица частот встречаемости символов \r\nв зашифрованном тексте";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(901, 499);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(373, 193);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(948, 318);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 32;
            label2.Text = "Поставить сдвиг:";
            // 
            // shiftTextBox
            // 
            shiftTextBox.Location = new Point(1120, 325);
            shiftTextBox.Name = "shiftTextBox";
            shiftTextBox.Size = new Size(124, 23);
            shiftTextBox.TabIndex = 33;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 20.25F);
            button1.Location = new Point(1269, 312);
            button1.Name = "button1";
            button1.Size = new Size(154, 41);
            button1.TabIndex = 34;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += check_shift;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(287, 499);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(373, 193);
            richTextBox2.TabIndex = 35;
            richTextBox2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(287, 432);
            label3.Name = "label3";
            label3.Size = new Size(522, 62);
            label3.TabIndex = 36;
            label3.Text = "Таблица частот встречаемости символов \r\nв английском языке";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1725, 717);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(shiftTextBox);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(EncrypttextBox1);
            Controls.Add(InformationtextBox);
            Controls.Add(EncrypttextBox0);
            Controls.Add(NtextBox1);
            Controls.Add(labelN1);
            Controls.Add(buttonClear);
            Controls.Add(K0textBox);
            Controls.Add(K1textBox);
            Controls.Add(labelDecrypt2);
            Controls.Add(button2);
            Controls.Add(labelDecrypt1);
            Controls.Add(buttonEncrypt);
            Controls.Add(labelK1);
            Controls.Add(labelK0);
            Controls.Add(labelInformation);
            Controls.Add(TextDecipher);
            Controls.Add(TextEncription);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextEncription;
        private Label TextDecipher;
        private Label labelInformation;
        private Label labelK0;
        private Label labelK1;
        private Button buttonEncrypt;
        private Label labelDecrypt1;
        private Button button2;
        private Label labelDecrypt2;
        private TextBox K1textBox;
        private TextBox K0textBox;
        private Button buttonClear;
        private TextBox NtextBox1;
        private Label labelN1;
        private RichTextBox EncrypttextBox0;
        private RichTextBox InformationtextBox;
        private RichTextBox EncrypttextBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox shiftTextBox;
        private Button button1;
        private RichTextBox richTextBox2;
        private Label label3;
    }
}
