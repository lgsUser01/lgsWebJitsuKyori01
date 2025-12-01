using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient; 

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lgsTrkSvr2NETX1;
namespace lgsCallKeiyuTenDll01
{
    public partial class Form1 : Form
    {
        lgsTrkSvr2NETX1.lgsTrkSvr2NETX1 TRKSVR2NETX1 = new lgsTrkSvr2NETX1.lgsTrkSvr2NETX1();
        public Form1()
        {
            InitializeComponent();
            this.textBox起点.Text = "11214";

            this.textBox終点.Text = "27201";
            this.textBoxSQL接続先.Text = @"MR8400\lgstrksvr"; // 【1】距離計算DB　SQLSDerverインスタンス
        }

        private void button計算実行_Click(object sender, EventArgs e)
        {
            bool blnCond = false;
            long lngIraiNo;
            bool blnReceive = false;
            bool blnKeisanStat = false;

            this.textBox距離.Text = "";
            this.textBox時間.Text = "";
            this.textBox有料距離.Text = "";
            this.textBox有料時間.Text = "";
            TRKSVR2NETX1.ServerComputerName =  this.textBoxSQL接続先.Text; 

            blnCond = TRKSVR2NETX1.lgsServerConnect();
            if (blnCond)
            {
                TRKSVR2NETX1.Kiten = this.textBox起点.Text;
                TRKSVR2NETX1.Shuuten = this.textBox終点.Text;
                TRKSVR2NETX1.KeisanJouken = 272;            // 【2】距離計算条件

                lngIraiNo = (long)TRKSVR2NETX1.Request();
                do
                {
                    blnReceive = (bool)TRKSVR2NETX1.Reply(lngIraiNo, ref blnKeisanStat);
                    System.Threading.Thread.Sleep(1);
                } while (blnReceive == false);
                if (blnKeisanStat == true)
                {
                    this.textBox距離.Text = string.Format("{0:####0}Km", TRKSVR2NETX1.KyoriM / 1000);  // String.Format(TRKSVR2NETX1.KyoriM / 1000, "####.000km"); 
                    this.textBox有料距離.Text = string.Format("{0:####0}Km", TRKSVR2NETX1.YuuryouKyoriM / 1000);  // String.Format(TRKSVR2NETX1.KyoriM / 1000, "####.000km"); 
                    this.textBox時間.Text = string.Format("{0:####0}秒", TRKSVR2NETX1.JikanS);  // String.Format(TRKSVR2NETX1.KyoriM / 1000, "####.000km"); 
                    this.textBox有料時間.Text = string.Format("{0:####0}秒", TRKSVR2NETX1.YuuryouJikanS);  // String.Format(TRKSVR2NETX1.KyoriM / 1000, "####.000km"); 

                }
                if (blnKeisanStat) this.textBox状況.Text = "true";
                else this.textBox状況.Text = "false";


            }

        }








    }
}
