using System;
using static System.Threading.Thread;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace lgsCallKeiyuTenDll01
{

    public partial class Form1
    {

        // Private TRKSVR2NETX1 As lgsTrkSvr2NETX1.TRKSVR2NETX ' lgsTrkSvr2NETX1.TRKSVR2NETX 'lgsTrkSvr2NETX1.TRKSVR2NETX 'Class距離計算
        private lgsTrkSvr2NETX1.lgsTrkSvr2NETX1 TRKSVR2NETX1;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            TRKSVR2NETX1 = new lgsTrkSvr2NETX1.lgsTrkSvr2NETX1(); // lgsTrkSvr2NETX1.TRKSVR2NETX

            TextBox起点.Text = "大阪府大阪市北区"; // "11216"
            TextBox終点.Text = "大阪府豊中市"; // "40216"

            TextBox経由地点1.Text = "和歌山県和歌山市";
            TextBox経由地点2.Text = "三重県津市";
            TextBox経由地点3.Text = "滋賀県米原市";
            TextBox経由地点4.Text = "大阪府高槻市";





        }

        private void Button距離計算_Click(object sender, EventArgs e)
        {


            bool blnCond;
            long lngIraiNo;
            bool blnReceive;
            var blnKeisanStatus = default(bool);
            int intKeisanJouken;


            TextBox距離.Text = ""; 
            TextBox直線距離.Text = ""; 

            TextBox認識住所.Text = ""; 
            TextBox区間距離1.Text = ""; 
            TextBox区間距離2.Text = ""; 
            TextBox区間距離3.Text = ""; 
            TextBox区間距離4.Text = "";
            TextBox区間距離5.Text = ""; 
            TextBox区間距離6.Text = "";

            TextBox認識住所.Text = "";
            TextBox状況.Text = "";

            // --20130529-- 計算条件
            intKeisanJouken = (int)lgsTrkSvr2NETX1.lgsTrkSvr2NETX1.JoukenType.時間優先;
            TRKSVR2NETX1.KeisanJouken = intKeisanJouken; // TR



            TRKSVR2NETX1.ServerComputerName = @"MR8400\lgstrksvr";  // 【1】距離計算DB　SQLSDerverインスタンス

            blnCond = TRKSVR2NETX1.lgsServerConnect();
            if (blnCond == true)
            {
                TRKSVR2NETX1.Kiten = TextBox起点.Text;
                TRKSVR2NETX1.Shuuten = TextBox終点.Text;



                // 経由点を設定する
                if (string.IsNullOrEmpty(TextBox経由地点1.Text))
                {
                    // 経由地点数
                    TRKSVR2NETX1.KeiyuChitenSuu = 0;
                }
                else
                {

                    TRKSVR2NETX1.Keiyuten[1] = TextBox経由地点1.Text;
                    if (string.IsNullOrEmpty(TextBox経由地点2.Text))
                    {
                        // 経由地点数
                        TRKSVR2NETX1.KeiyuChitenSuu = 1;
                    }
                    else
                    {
                        TRKSVR2NETX1.Keiyuten[2] = TextBox経由地点2.Text;
                        if (string.IsNullOrEmpty(TextBox経由地点3.Text))
                        {
                            // 経由地点数
                            TRKSVR2NETX1.KeiyuChitenSuu = 2;
                        }
                        else
                        {
                            TRKSVR2NETX1.Keiyuten[3] = TextBox経由地点3.Text;
                            if (string.IsNullOrEmpty(TextBox経由地点4.Text))
                            {
                                // 経由地点数
                                TRKSVR2NETX1.KeiyuChitenSuu = 3;
                            }
                            else
                            {
                                TRKSVR2NETX1.Keiyuten[4] = TextBox経由地点4.Text;
                                if (string.IsNullOrEmpty(TextBox経由地点5.Text))
                                {
                                    // 経由地点数
                                    TRKSVR2NETX1.KeiyuChitenSuu = 4;
                                }
                                else
                                {
                                    TRKSVR2NETX1.Keiyuten[5] = TextBox経由地点5.Text;
                                    // 経由地点数
                                    TRKSVR2NETX1.KeiyuChitenSuu = 5;
                                }
                            }
                        }
                    }
                }


                lngIraiNo = TRKSVR2NETX1.Request();

                blnReceive = false;
                while (blnReceive == false)
                {
                    blnReceive = TRKSVR2NETX1.Reply(lngIraiNo, ref blnKeisanStatus);
                    Sleep(10);
                }
                if (blnKeisanStatus == true)
                {
                    TextBox距離.Text = Strings.Format(TRKSVR2NETX1.KyoriM / 1000d, "#####");
                    TextBox直線距離.Text = Strings.Format(TRKSVR2NETX1.ChokusenKyoriM / 1000d, "#####");

                    TextBox認識住所.Text = TRKSVR2NETX1.KitenNinshikiJuusho + "→" + TRKSVR2NETX1.ShuutenNinshikiJuusho;
                    // --20080622-

                    // 区間距離

                    TextBox区間距離1.Text = Strings.Format(TRKSVR2NETX1.KeiyuKyoriM[1] / 1000d, "#####");

                    TextBox区間距離2.Text = Strings.Format(TRKSVR2NETX1.KeiyuKyoriM[2] / 1000d, "#####");
                    TextBox区間距離3.Text = Strings.Format(TRKSVR2NETX1.KeiyuKyoriM[3] / 1000d, "#####");
                    TextBox区間距離4.Text = Strings.Format(TRKSVR2NETX1.KeiyuKyoriM[4] / 1000d, "#####");
                    TextBox区間距離5.Text = Strings.Format(TRKSVR2NETX1.KeiyuKyoriM[5] / 1000d, "#####");
                }

                else
                {
                    TextBox距離.Text = ""; // Format(TRKSVR2NETX1.KyoriM / 1000, "####.000Km")
                    TextBox直線距離.Text = ""; // Format(TRKSVR2NETX1.ChokusenKyoriM / 1000, "####.000Km")

                    TextBox認識住所.Text = ""; // TRKSVR2NETX1.KitenNinshikiJuusho & _
                                           // "→" & TRKSVR2NETX1.ShuutenNinshikiJuusho  '--20080622-
                                           // "→" & TRKSVR2NETX1.ShuutenIchi
                                           // 区間距離
                    TextBox区間距離1.Text = ""; // TRKSVR2NETX1.KeiyuKyoriM(1).ToString
                    TextBox区間距離2.Text = ""; // TRKSVR2NETX1.KeiyuKyoriM(2).ToString
                    TextBox区間距離3.Text = ""; // TRKSVR2NETX1.KeiyuKyoriM(3).ToString
                    TextBox区間距離4.Text = ""; // TRKSVR2NETX1.KeiyuKyoriM(4).ToString
                    TextBox区間距離5.Text = "";


                } // TRKSVR2NETX1.KeiyuKyoriM(5).ToString


            }
            TextBox状況.Text = Conversions.ToString(blnKeisanStatus);





        }

        private void Button経由地点クリア_Click(object sender, EventArgs e)
        {
            TextBox区間距離1.Text = ""; // TRKSVR1NETX1.KeiyuKyoriM(1).ToString
            TextBox区間距離2.Text = ""; // TRKSVR1NETX1.KeiyuKyoriM(2).ToString
            TextBox区間距離3.Text = ""; // TRKSVR1NETX1.KeiyuKyoriM(3).ToString
            TextBox区間距離4.Text = ""; // TRKSVR1NETX1.KeiyuKyoriM(4).ToString
            TextBox区間距離5.Text = ""; // TRKSVR1NETX1.KeiyuKyoriM(5).ToString
            TextBox区間距離6.Text = "";

            TextBox経由地点1.Text = "";
            TextBox経由地点2.Text = "";
            TextBox経由地点3.Text = "";
            TextBox経由地点4.Text = "";
            TextBox経由地点5.Text = "";
        }
    }
}