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
            labelEncrypt1 = new Label();
            buttonDecrypt = new Button();
            labelK11 = new Label();
            labelK01 = new Label();
            labelDecrypt2 = new Label();
            InformationtextBox = new TextBox();
            K1textBox = new TextBox();
            K0textBox = new TextBox();
            EncrypttextBox1 = new TextBox();
            K0textBox1 = new TextBox();
            K1textBox1 = new TextBox();
            EncrypttextBox = new TextBox();
            EncrypttextBox0 = new TextBox();
            buttonClear = new Button();
            NtextBox1 = new TextBox();
            labelN1 = new Label();
            NtextBox2 = new TextBox();
            labelN2 = new Label();
            SuspendLayout();
            // 
            // TextEncription
            // 
            TextEncription.AutoSize = true;
            TextEncription.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextEncription.Location = new Point(99, 45);
            TextEncription.Name = "TextEncription";
            TextEncription.Size = new Size(314, 55);
            TextEncription.TabIndex = 0;
            TextEncription.Text = "Шифрование";
            // 
            // TextDecipher
            // 
            TextDecipher.AutoSize = true;
            TextDecipher.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextDecipher.Location = new Point(876, 45);
            TextDecipher.Name = "TextDecipher";
            TextDecipher.Size = new Size(358, 55);
            TextDecipher.TabIndex = 1;
            TextDecipher.Text = "Дешифрование";
            // 
            // labelInformation
            // 
            labelInformation.AutoSize = true;
            labelInformation.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInformation.Location = new Point(96, 211);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(218, 31);
            labelInformation.TabIndex = 2;
            labelInformation.Text = "Исходный текст:";
            // 
            // labelK0
            // 
            labelK0.AutoSize = true;
            labelK0.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelK0.Location = new Point(96, 321);
            labelK0.Name = "labelK0";
            labelK0.Size = new Size(164, 31);
            labelK0.TabIndex = 3;
            labelK0.Text = "Введите K0:";
            // 
            // labelK1
            // 
            labelK1.AutoSize = true;
            labelK1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelK1.Location = new Point(96, 371);
            labelK1.Name = "labelK1";
            labelK1.Size = new Size(164, 31);
            labelK1.TabIndex = 4;
            labelK1.Text = "Введите K1:";
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEncrypt.Location = new Point(96, 423);
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
            labelDecrypt1.Location = new Point(96, 506);
            labelDecrypt1.Name = "labelDecrypt1";
            labelDecrypt1.Size = new Size(283, 31);
            labelDecrypt1.TabIndex = 6;
            labelDecrypt1.Text = "Шифрованный текст:";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 20.25F);
            button2.Location = new Point(96, 639);
            button2.Name = "button2";
            button2.Size = new Size(154, 41);
            button2.TabIndex = 7;
            button2.Text = "Отправить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonTransfer_Click;
            // 
            // labelEncrypt1
            // 
            labelEncrypt1.AutoSize = true;
            labelEncrypt1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEncrypt1.Location = new Point(881, 513);
            labelEncrypt1.Name = "labelEncrypt1";
            labelEncrypt1.Size = new Size(218, 31);
            labelEncrypt1.TabIndex = 12;
            labelEncrypt1.Text = "Исходный текст:";
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDecrypt.Location = new Point(881, 423);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(195, 50);
            buttonDecrypt.TabIndex = 11;
            buttonDecrypt.Text = "Дешифровать";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // labelK11
            // 
            labelK11.AutoSize = true;
            labelK11.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelK11.Location = new Point(881, 371);
            labelK11.Name = "labelK11";
            labelK11.Size = new Size(164, 31);
            labelK11.TabIndex = 10;
            labelK11.Text = "Введите K1:";
            // 
            // labelK01
            // 
            labelK01.AutoSize = true;
            labelK01.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelK01.Location = new Point(882, 321);
            labelK01.Name = "labelK01";
            labelK01.Size = new Size(164, 31);
            labelK01.TabIndex = 9;
            labelK01.Text = "Введите K0:";
            // 
            // labelDecrypt2
            // 
            labelDecrypt2.AutoSize = true;
            labelDecrypt2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDecrypt2.Location = new Point(882, 211);
            labelDecrypt2.Name = "labelDecrypt2";
            labelDecrypt2.Size = new Size(283, 31);
            labelDecrypt2.TabIndex = 8;
            labelDecrypt2.Text = "Шифрованный текст:";
            // 
            // InformationtextBox
            // 
            InformationtextBox.Location = new Point(317, 219);
            InformationtextBox.Name = "InformationtextBox";
            InformationtextBox.Size = new Size(240, 23);
            InformationtextBox.TabIndex = 14;
            // 
            // K1textBox
            // 
            K1textBox.Location = new Point(265, 381);
            K1textBox.Name = "K1textBox";
            K1textBox.Size = new Size(34, 23);
            K1textBox.TabIndex = 15;
            // 
            // K0textBox
            // 
            K0textBox.Location = new Point(265, 329);
            K0textBox.Name = "K0textBox";
            K0textBox.Size = new Size(34, 23);
            K0textBox.TabIndex = 16;
            // 
            // EncrypttextBox1
            // 
            EncrypttextBox1.Location = new Point(1171, 219);
            EncrypttextBox1.Name = "EncrypttextBox1";
            EncrypttextBox1.Size = new Size(240, 23);
            EncrypttextBox1.TabIndex = 17;
            // 
            // K0textBox1
            // 
            K0textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            K0textBox1.Location = new Point(1051, 326);
            K0textBox1.Name = "K0textBox1";
            K0textBox1.Size = new Size(34, 25);
            K0textBox1.TabIndex = 19;
            // 
            // K1textBox1
            // 
            K1textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            K1textBox1.Location = new Point(1051, 379);
            K1textBox1.Name = "K1textBox1";
            K1textBox1.Size = new Size(34, 25);
            K1textBox1.TabIndex = 18;
            // 
            // EncrypttextBox
            // 
            EncrypttextBox.Location = new Point(1105, 519);
            EncrypttextBox.Name = "EncrypttextBox";
            EncrypttextBox.Size = new Size(240, 23);
            EncrypttextBox.TabIndex = 20;
            // 
            // EncrypttextBox0
            // 
            EncrypttextBox0.Location = new Point(375, 514);
            EncrypttextBox0.Name = "EncrypttextBox0";
            EncrypttextBox0.Size = new Size(240, 23);
            EncrypttextBox0.TabIndex = 21;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Times New Roman", 20.25F);
            buttonClear.Location = new Point(317, 639);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(154, 41);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // NtextBox1
            // 
            NtextBox1.Location = new Point(265, 283);
            NtextBox1.Name = "NtextBox1";
            NtextBox1.Size = new Size(34, 23);
            NtextBox1.TabIndex = 24;
            // 
            // labelN1
            // 
            labelN1.AutoSize = true;
            labelN1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelN1.Location = new Point(96, 275);
            labelN1.Name = "labelN1";
            labelN1.Size = new Size(144, 31);
            labelN1.TabIndex = 23;
            labelN1.Text = "Введите n:";
            // 
            // NtextBox2
            // 
            NtextBox2.Location = new Point(1051, 286);
            NtextBox2.Name = "NtextBox2";
            NtextBox2.Size = new Size(34, 23);
            NtextBox2.TabIndex = 26;
            // 
            // labelN2
            // 
            labelN2.AutoSize = true;
            labelN2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            labelN2.Location = new Point(882, 281);
            labelN2.Name = "labelN2";
            labelN2.Size = new Size(144, 31);
            labelN2.TabIndex = 25;
            labelN2.Text = "Введите n:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 717);
            Controls.Add(NtextBox2);
            Controls.Add(labelN2);
            Controls.Add(NtextBox1);
            Controls.Add(labelN1);
            Controls.Add(buttonClear);
            Controls.Add(EncrypttextBox0);
            Controls.Add(EncrypttextBox);
            Controls.Add(K0textBox1);
            Controls.Add(K1textBox1);
            Controls.Add(EncrypttextBox1);
            Controls.Add(K0textBox);
            Controls.Add(K1textBox);
            Controls.Add(InformationtextBox);
            Controls.Add(labelEncrypt1);
            Controls.Add(buttonDecrypt);
            Controls.Add(labelK11);
            Controls.Add(labelK01);
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
        private Label labelEncrypt1;
        private Button buttonDecrypt;
        private Label labelK11;
        private Label labelK01;
        private Label labelDecrypt2;
        private TextBox InformationtextBox;
        private TextBox K1textBox;
        private TextBox K0textBox;
        private TextBox EncrypttextBox1;
        private TextBox K0textBox1;
        private TextBox K1textBox1;
        private TextBox EncrypttextBox;
        private TextBox EncrypttextBox0;
        private Button buttonClear;
        private TextBox NtextBox1;
        private Label labelN1;
        private TextBox NtextBox2;
        private Label labelN2;
    }
}
