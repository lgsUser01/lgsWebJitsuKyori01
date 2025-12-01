using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace lgsCallKeiyuTenDll01
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Windows フォーム デザイナで必要です。
        private System.ComponentModel.IContainer components;

        // メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
        // Windows フォーム デザイナを使用して変更できます。  
        // コード エディタを使って変更しないでください。
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Label1 = new Label();
            TextBox起点 = new TextBox();
            Label10 = new Label();
            TextBox経由地点1 = new TextBox();
            Label11 = new Label();
            TextBox経由地点2 = new TextBox();
            Label12 = new Label();
            TextBox経由地点3 = new TextBox();
            Label13 = new Label();
            TextBox経由地点4 = new TextBox();
            Label15 = new Label();
            TextBox経由地点5 = new TextBox();
            Label2 = new Label();
            TextBox終点 = new TextBox();
            Label14 = new Label();
            TextBox区間距離1 = new TextBox();
            TextBox区間距離2 = new TextBox();
            TextBox区間距離3 = new TextBox();
            TextBox区間距離4 = new TextBox();
            TextBox区間距離5 = new TextBox();
            TextBox区間距離6 = new TextBox();
            Button経由地点クリア = new Button();
            Button経由地点クリア.Click += new EventHandler(Button経由地点クリア_Click);
            Button距離計算 = new Button();
            Button距離計算.Click += new EventHandler(Button距離計算_Click);
            Label3 = new Label();
            TextBox距離 = new TextBox();
            Label4 = new Label();
            TextBox直線距離 = new TextBox();
            Label5 = new Label();
            TextBox認識住所 = new TextBox();
            Label7 = new Label();
            TextBox状況 = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(29, 12);
            Label1.TabIndex = 40;
            Label1.Text = "起点";
            // 
            // TextBox起点
            // 
            TextBox起点.Location = new Point(63, 17);
            TextBox起点.Name = "TextBox起点";
            TextBox起点.Size = new Size(271, 19);
            TextBox起点.TabIndex = 41;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(12, 55);
            Label10.Name = "Label10";
            Label10.Size = new Size(59, 12);
            Label10.TabIndex = 57;
            Label10.Text = "経由地点1";
            // 
            // TextBox経由地点1
            // 
            TextBox経由地点1.Location = new Point(84, 48);
            TextBox経由地点1.Name = "TextBox経由地点1";
            TextBox経由地点1.Size = new Size(250, 19);
            TextBox経由地点1.TabIndex = 58;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(12, 89);
            Label11.Name = "Label11";
            Label11.Size = new Size(59, 12);
            Label11.TabIndex = 59;
            Label11.Text = "経由地点2";
            // 
            // TextBox経由地点2
            // 
            TextBox経由地点2.Location = new Point(84, 82);
            TextBox経由地点2.Name = "TextBox経由地点2";
            TextBox経由地点2.Size = new Size(251, 19);
            TextBox経由地点2.TabIndex = 60;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(12, 121);
            Label12.Name = "Label12";
            Label12.Size = new Size(59, 12);
            Label12.TabIndex = 61;
            Label12.Text = "経由地点3";
            // 
            // TextBox経由地点3
            // 
            TextBox経由地点3.Location = new Point(85, 118);
            TextBox経由地点3.Name = "TextBox経由地点3";
            TextBox経由地点3.Size = new Size(250, 19);
            TextBox経由地点3.TabIndex = 62;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(12, 152);
            Label13.Name = "Label13";
            Label13.Size = new Size(59, 12);
            Label13.TabIndex = 63;
            Label13.Text = "経由地点4";
            // 
            // TextBox経由地点4
            // 
            TextBox経由地点4.Location = new Point(85, 152);
            TextBox経由地点4.Name = "TextBox経由地点4";
            TextBox経由地点4.Size = new Size(250, 19);
            TextBox経由地点4.TabIndex = 64;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(12, 185);
            Label15.Name = "Label15";
            Label15.Size = new Size(59, 12);
            Label15.TabIndex = 71;
            Label15.Text = "経由地点5";
            // 
            // TextBox経由地点5
            // 
            TextBox経由地点5.Location = new Point(85, 182);
            TextBox経由地点5.Name = "TextBox経由地点5";
            TextBox経由地点5.Size = new Size(250, 19);
            TextBox経由地点5.TabIndex = 72;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 236);
            Label2.Name = "Label2";
            Label2.Size = new Size(29, 12);
            Label2.TabIndex = 73;
            Label2.Text = "終点";
            // 
            // TextBox終点
            // 
            TextBox終点.Location = new Point(73, 229);
            TextBox終点.Name = "TextBox終点";
            TextBox終点.Size = new Size(271, 19);
            TextBox終点.TabIndex = 74;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(355, 24);
            Label14.Name = "Label14";
            Label14.Size = new Size(77, 12);
            Label14.TabIndex = 75;
            Label14.Text = "区間距離(Km)";
            // 
            // TextBox区間距離1
            // 
            TextBox区間距離1.Location = new Point(357, 48);
            TextBox区間距離1.Name = "TextBox区間距離1";
            TextBox区間距離1.Size = new Size(75, 19);
            TextBox区間距離1.TabIndex = 76;
            TextBox区間距離1.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox区間距離2
            // 
            TextBox区間距離2.Location = new Point(357, 82);
            TextBox区間距離2.Name = "TextBox区間距離2";
            TextBox区間距離2.Size = new Size(75, 19);
            TextBox区間距離2.TabIndex = 77;
            TextBox区間距離2.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox区間距離3
            // 
            TextBox区間距離3.Location = new Point(357, 118);
            TextBox区間距離3.Name = "TextBox区間距離3";
            TextBox区間距離3.Size = new Size(75, 19);
            TextBox区間距離3.TabIndex = 78;
            TextBox区間距離3.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox区間距離4
            // 
            TextBox区間距離4.Location = new Point(357, 152);
            TextBox区間距離4.Name = "TextBox区間距離4";
            TextBox区間距離4.Size = new Size(75, 19);
            TextBox区間距離4.TabIndex = 79;
            TextBox区間距離4.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox区間距離5
            // 
            TextBox区間距離5.Location = new Point(359, 185);
            TextBox区間距離5.Name = "TextBox区間距離5";
            TextBox区間距離5.Size = new Size(73, 19);
            TextBox区間距離5.TabIndex = 80;
            TextBox区間距離5.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox区間距離6
            // 
            TextBox区間距離6.Location = new Point(359, 220);
            TextBox区間距離6.Name = "TextBox区間距離6";
            TextBox区間距離6.Size = new Size(75, 19);
            TextBox区間距離6.TabIndex = 81;
            TextBox区間距離6.TextAlign = HorizontalAlignment.Right;
            // 
            // Button経由地点クリア
            // 
            Button経由地点クリア.Location = new Point(456, 48);
            Button経由地点クリア.Name = "Button経由地点クリア";
            Button経由地点クリア.Size = new Size(124, 21);
            Button経由地点クリア.TabIndex = 82;
            Button経由地点クリア.Text = "経由地点クリア";
            Button経由地点クリア.UseVisualStyleBackColor = true;
            // 
            // Button距離計算
            // 
            Button距離計算.Location = new Point(14, 269);
            Button距離計算.Name = "Button距離計算";
            Button距離計算.Size = new Size(82, 23);
            Button距離計算.TabIndex = 83;
            Button距離計算.Text = "距離計算";
            Button距離計算.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(118, 274);
            Label3.Name = "Label3";
            Label3.Size = new Size(53, 12);
            Label3.TabIndex = 84;
            Label3.Text = "距離(Km)";
            // 
            // TextBox距離
            // 
            TextBox距離.Location = new Point(177, 269);
            TextBox距離.Name = "TextBox距離";
            TextBox距離.Size = new Size(82, 19);
            TextBox距離.TabIndex = 85;
            TextBox距離.TextAlign = HorizontalAlignment.Right;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(279, 272);
            Label4.Name = "Label4";
            Label4.Size = new Size(77, 12);
            Label4.TabIndex = 86;
            Label4.Text = "直線距離(Km)";
            // 
            // TextBox直線距離
            // 
            TextBox直線距離.Location = new Point(362, 265);
            TextBox直線距離.Name = "TextBox直線距離";
            TextBox直線距離.Size = new Size(81, 19);
            TextBox直線距離.TabIndex = 87;
            TextBox直線距離.TextAlign = HorizontalAlignment.Right;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(43, 307);
            Label5.Name = "Label5";
            Label5.Size = new Size(53, 12);
            Label5.TabIndex = 88;
            Label5.Text = "認識住所";
            // 
            // TextBox認識住所
            // 
            TextBox認識住所.Location = new Point(120, 304);
            TextBox認識住所.Name = "TextBox認識住所";
            TextBox認識住所.Size = new Size(402, 19);
            TextBox認識住所.TabIndex = 89;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(43, 339);
            Label7.Name = "Label7";
            Label7.Size = new Size(29, 12);
            Label7.TabIndex = 90;
            Label7.Text = "状況";
            // 
            // TextBox状況
            // 
            TextBox状況.Location = new Point(120, 336);
            TextBox状況.Name = "TextBox状況";
            TextBox状況.Size = new Size(89, 19);
            TextBox状況.TabIndex = 91;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 12.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 530);
            Controls.Add(TextBox状況);
            Controls.Add(Label7);
            Controls.Add(TextBox認識住所);
            Controls.Add(Label5);
            Controls.Add(TextBox直線距離);
            Controls.Add(Label4);
            Controls.Add(TextBox距離);
            Controls.Add(Label3);
            Controls.Add(Button距離計算);
            Controls.Add(Button経由地点クリア);
            Controls.Add(TextBox区間距離6);
            Controls.Add(TextBox区間距離5);
            Controls.Add(TextBox区間距離4);
            Controls.Add(TextBox区間距離3);
            Controls.Add(TextBox区間距離2);
            Controls.Add(TextBox区間距離1);
            Controls.Add(Label14);
            Controls.Add(TextBox終点);
            Controls.Add(Label2);
            Controls.Add(TextBox経由地点5);
            Controls.Add(Label15);
            Controls.Add(TextBox経由地点4);
            Controls.Add(Label13);
            Controls.Add(TextBox経由地点3);
            Controls.Add(Label12);
            Controls.Add(TextBox経由地点2);
            Controls.Add(Label11);
            Controls.Add(TextBox経由地点1);
            Controls.Add(Label10);
            Controls.Add(TextBox起点);
            Controls.Add(Label1);
            Name = "Form1";
            Text = "Form1";
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal TextBox TextBox起点;
        internal Label Label10;
        internal TextBox TextBox経由地点1;
        internal Label Label11;
        internal TextBox TextBox経由地点2;
        internal Label Label12;
        internal TextBox TextBox経由地点3;
        internal Label Label13;
        internal TextBox TextBox経由地点4;
        internal Label Label15;
        internal TextBox TextBox経由地点5;
        internal Label Label2;
        internal TextBox TextBox終点;
        internal Label Label14;
        internal TextBox TextBox区間距離1;
        internal TextBox TextBox区間距離2;
        internal TextBox TextBox区間距離3;
        internal TextBox TextBox区間距離4;
        internal TextBox TextBox区間距離5;
        internal TextBox TextBox区間距離6;
        internal Button Button経由地点クリア;
        internal Button Button距離計算;
        internal Label Label3;
        internal TextBox TextBox距離;
        internal Label Label4;
        internal TextBox TextBox直線距離;
        internal Label Label5;
        internal TextBox TextBox認識住所;
        internal Label Label7;
        internal TextBox TextBox状況;

    }
}