
namespace lgsCallKeiyuTenDll01
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
            this.textBox状況 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox有料時間 = new System.Windows.Forms.TextBox();
            this.textBox有料距離 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox時間 = new System.Windows.Forms.TextBox();
            this.textBox距離 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button計算実行 = new System.Windows.Forms.Button();
            this.textBox終点 = new System.Windows.Forms.TextBox();
            this.label終点 = new System.Windows.Forms.Label();
            this.textBox起点 = new System.Windows.Forms.TextBox();
            this.Label起点 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSQL接続先 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox状況
            // 
            this.textBox状況.Location = new System.Drawing.Point(160, 214);
            this.textBox状況.Name = "textBox状況";
            this.textBox状況.Size = new System.Drawing.Size(73, 19);
            this.textBox状況.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "状況";
            // 
            // textBox有料時間
            // 
            this.textBox有料時間.Location = new System.Drawing.Point(283, 178);
            this.textBox有料時間.Name = "textBox有料時間";
            this.textBox有料時間.Size = new System.Drawing.Size(82, 19);
            this.textBox有料時間.TabIndex = 27;
            // 
            // textBox有料距離
            // 
            this.textBox有料距離.Location = new System.Drawing.Point(159, 178);
            this.textBox有料距離.Name = "textBox有料距離";
            this.textBox有料距離.Size = new System.Drawing.Size(87, 19);
            this.textBox有料距離.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "有料道路";
            // 
            // textBox時間
            // 
            this.textBox時間.Location = new System.Drawing.Point(283, 153);
            this.textBox時間.Name = "textBox時間";
            this.textBox時間.Size = new System.Drawing.Size(85, 19);
            this.textBox時間.TabIndex = 24;
            // 
            // textBox距離
            // 
            this.textBox距離.Location = new System.Drawing.Point(158, 153);
            this.textBox距離.Name = "textBox距離";
            this.textBox距離.Size = new System.Drawing.Size(88, 19);
            this.textBox距離.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "一般道路";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "時間";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "距離";
            // 
            // button計算実行
            // 
            this.button計算実行.Location = new System.Drawing.Point(28, 121);
            this.button計算実行.Name = "button計算実行";
            this.button計算実行.Size = new System.Drawing.Size(90, 21);
            this.button計算実行.TabIndex = 19;
            this.button計算実行.Text = "計算実行";
            this.button計算実行.UseVisualStyleBackColor = true;
            this.button計算実行.Click += new System.EventHandler(this.button計算実行_Click);
            // 
            // textBox終点
            // 
            this.textBox終点.Location = new System.Drawing.Point(75, 85);
            this.textBox終点.Name = "textBox終点";
            this.textBox終点.Size = new System.Drawing.Size(261, 19);
            this.textBox終点.TabIndex = 18;
            // 
            // label終点
            // 
            this.label終点.AutoSize = true;
            this.label終点.Location = new System.Drawing.Point(26, 92);
            this.label終点.Name = "label終点";
            this.label終点.Size = new System.Drawing.Size(29, 12);
            this.label終点.TabIndex = 17;
            this.label終点.Text = "終点";
            // 
            // textBox起点
            // 
            this.textBox起点.Location = new System.Drawing.Point(75, 53);
            this.textBox起点.Name = "textBox起点";
            this.textBox起点.Size = new System.Drawing.Size(265, 19);
            this.textBox起点.TabIndex = 16;
            // 
            // Label起点
            // 
            this.Label起点.AutoSize = true;
            this.Label起点.Location = new System.Drawing.Point(26, 60);
            this.Label起点.Name = "Label起点";
            this.Label起点.Size = new System.Drawing.Size(29, 12);
            this.Label起点.TabIndex = 15;
            this.Label起点.Text = "起点";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "SQL接続先";
            // 
            // textBoxSQL接続先
            // 
            this.textBoxSQL接続先.Location = new System.Drawing.Point(75, 15);
            this.textBoxSQL接続先.Name = "textBoxSQL接続先";
            this.textBoxSQL接続先.Size = new System.Drawing.Size(260, 19);
            this.textBoxSQL接続先.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 255);
            this.Controls.Add(this.textBoxSQL接続先);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox状況);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox有料時間);
            this.Controls.Add(this.textBox有料距離);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox時間);
            this.Controls.Add(this.textBox距離);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button計算実行);
            this.Controls.Add(this.textBox終点);
            this.Controls.Add(this.label終点);
            this.Controls.Add(this.textBox起点);
            this.Controls.Add(this.Label起点);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox状況;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox有料時間;
        private System.Windows.Forms.TextBox textBox有料距離;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox時間;
        private System.Windows.Forms.TextBox textBox距離;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button計算実行;
        private System.Windows.Forms.TextBox textBox終点;
        private System.Windows.Forms.Label label終点;
        private System.Windows.Forms.TextBox textBox起点;
        private System.Windows.Forms.Label Label起点;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSQL接続先;
    }
}

