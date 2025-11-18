namespace lgsCallMyWebApiHttpClient01
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            textBoxWebApiUrl = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox距離Meter = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox終点 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox起点 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            httpClient呼び出しToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label7 = new System.Windows.Forms.Label();
            textBoxSQL接続先 = new System.Windows.Forms.TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxWebApiUrl
            // 
            textBoxWebApiUrl.Location = new System.Drawing.Point(130, 25);
            textBoxWebApiUrl.Margin = new System.Windows.Forms.Padding(4);
            textBoxWebApiUrl.Name = "textBoxWebApiUrl";
            textBoxWebApiUrl.Size = new System.Drawing.Size(438, 23);
            textBoxWebApiUrl.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 34);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 61;
            label5.Text = "WebApiURL";
            // 
            // textBox距離Meter
            // 
            textBox距離Meter.Location = new System.Drawing.Point(127, 188);
            textBox距離Meter.Margin = new System.Windows.Forms.Padding(4);
            textBox距離Meter.Name = "textBox距離Meter";
            textBox距離Meter.Size = new System.Drawing.Size(116, 23);
            textBox距離Meter.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 196);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 15);
            label3.TabIndex = 57;
            label3.Text = "距離Meter";
            // 
            // textBox終点
            // 
            textBox終点.Location = new System.Drawing.Point(130, 138);
            textBox終点.Margin = new System.Windows.Forms.Padding(4);
            textBox終点.Name = "textBox終点";
            textBox終点.Size = new System.Drawing.Size(122, 23);
            textBox終点.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 138);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 55;
            label2.Text = "終点";
            // 
            // textBox起点
            // 
            textBox起点.Location = new System.Drawing.Point(130, 90);
            textBox起点.Margin = new System.Windows.Forms.Padding(4);
            textBox起点.Name = "textBox起点";
            textBox起点.Size = new System.Drawing.Size(123, 23);
            textBox起点.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 98);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 53;
            label1.Text = "起点";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { httpClient呼び出しToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(825, 24);
            menuStrip1.TabIndex = 65;
            menuStrip1.Text = "menuStrip1";
            // 
            // httpClient呼び出しToolStripMenuItem
            // 
            httpClient呼び出しToolStripMenuItem.Name = "httpClient呼び出しToolStripMenuItem";
            httpClient呼び出しToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            httpClient呼び出しToolStripMenuItem.Text = "HttpClient呼び出し";
            httpClient呼び出しToolStripMenuItem.Click += httpClient呼び出しToolStripMenuItem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(14, 65);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 15);
            label7.TabIndex = 66;
            label7.Text = "SQL接続先";
            // 
            // textBoxSQL接続先
            // 
            textBoxSQL接続先.Location = new System.Drawing.Point(132, 57);
            textBoxSQL接続先.Name = "textBoxSQL接続先";
            textBoxSQL接続先.Size = new System.Drawing.Size(345, 23);
            textBoxSQL接続先.TabIndex = 67;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(825, 276);
            Controls.Add(textBoxSQL接続先);
            Controls.Add(label7);
            Controls.Add(textBoxWebApiUrl);
            Controls.Add(label5);
            Controls.Add(textBox距離Meter);
            Controls.Add(label3);
            Controls.Add(textBox終点);
            Controls.Add(label2);
            Controls.Add(textBox起点);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWebApiUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox距離Meter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox終点;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox起点;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem httpClient呼び出しToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSQL接続先;
    }
}

