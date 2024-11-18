namespace WinFormsApp1
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancel = new Button();
            buttonContinue = new Button();
            labelInfo = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Times New Roman", 14.25F);
            buttonCancel.Location = new Point(25, 174);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(128, 34);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Прервать";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new Font("Times New Roman", 14.25F);
            buttonContinue.Location = new Point(317, 174);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(124, 34);
            buttonContinue.TabIndex = 1;
            buttonContinue.Text = "Выполнить";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInfo.Location = new Point(12, 72);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(449, 26);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "k1 и n должны быть взаимно простыми!";
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 245);
            Controls.Add(labelInfo);
            Controls.Add(buttonContinue);
            Controls.Add(buttonCancel);
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonContinue;
        private Label labelInfo;
    }
}