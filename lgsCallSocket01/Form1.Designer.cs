namespace lgsCallSocket01
{
    partial class Form1
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
            button受信クリア = new Button();
            textBox接続先 = new TextBox();
            label3 = new Label();
            textBox受信 = new TextBox();
            label2 = new Label();
            button送信 = new Button();
            textBox送信 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button受信クリア
            // 
            button受信クリア.Location = new Point(287, 162);
            button受信クリア.Margin = new Padding(4, 4, 4, 4);
            button受信クリア.Name = "button受信クリア";
            button受信クリア.Size = new Size(108, 29);
            button受信クリア.TabIndex = 15;
            button受信クリア.Text = "受信クリア";
            button受信クリア.UseVisualStyleBackColor = true;
            button受信クリア.Click += button受信クリア_Click_1;
            // 
            // textBox接続先
            // 
            textBox接続先.Location = new Point(16, 36);
            textBox接続先.Margin = new Padding(4, 4, 4, 4);
            textBox接続先.Name = "textBox接続先";
            textBox接続先.Size = new Size(165, 23);
            textBox接続先.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 13;
            label3.Text = "接続先コンピュータ";
            // 
            // textBox受信
            // 
            textBox受信.Location = new Point(16, 214);
            textBox受信.Margin = new Padding(4, 4, 4, 4);
            textBox受信.Multiline = true;
            textBox受信.Name = "textBox受信";
            textBox受信.Size = new Size(482, 62);
            textBox受信.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "受信";
            // 
            // button送信
            // 
            button送信.Location = new Point(34, 162);
            button送信.Margin = new Padding(4, 4, 4, 4);
            button送信.Name = "button送信";
            button送信.Size = new Size(130, 29);
            button送信.TabIndex = 10;
            button送信.Text = "ソケット送信";
            button送信.UseVisualStyleBackColor = true;
            button送信.Click += button送信_Click_1;
            // 
            // textBox送信
            // 
            textBox送信.Location = new Point(16, 82);
            textBox送信.Margin = new Padding(4, 4, 4, 4);
            textBox送信.Multiline = true;
            textBox送信.Name = "textBox送信";
            textBox送信.Size = new Size(482, 72);
            textBox送信.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 8;
            label1.Text = "送信(距離計算条件,起点,終点)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 311);
            Controls.Add(button受信クリア);
            Controls.Add(textBox接続先);
            Controls.Add(label3);
            Controls.Add(textBox受信);
            Controls.Add(label2);
            Controls.Add(button送信);
            Controls.Add(textBox送信);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button受信クリア;
        private System.Windows.Forms.TextBox textBox接続先;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox受信;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button送信;
        private System.Windows.Forms.TextBox textBox送信;
        private System.Windows.Forms.Label label1;
    }
}