using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lgsCallMyWebApiHttpClient01
{
    public partial class Form1 : Form
    {

    

        public class Kyori
        {
            //public string KyoriName { get; set; }
            public int KyoriMeter { get; set; }
        }
       

        public Form1()
        {
            InitializeComponent();

            this.textBoxSQL接続先.Text = @"MR8400\lgstrksvr";              //  【1】距離計算DB　SQLSDerverインスタンス
            this.textBoxWebApiUrl.Text = "https://localhost:5000/api/K/";   // 【2】WebAPIのURL

            this.textBox起点.Text = "13102";
            this.textBox終点.Text = "27127";

            
        }

        private async void httpClient呼び出しToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Url作成
            string F = this.textBox起点.Text;
            string T = this.textBox終点.Text;

          

            string WepApiUrl = this.textBoxWebApiUrl.Text;
            string Url = WepApiUrl + "?f=" + F + "&t=" + T;
            // WebApi呼び出し
            Kyori kyori = await WebApiKyoriMeter(Url);

            // 結果
            this.textBox距離Meter.Text = kyori.KyoriMeter.ToString();
           

        }


        private async Task<Kyori> WebApiKyoriMeter(string Url)
        {

            // 【2】プロキシ認証の指定
            string strProxyServer = "ProxyServer"; //.Pstring.Empty;   // (1)サーバ名
            string strUserName = "ProxyUserName"; // string.Empty;  // (2)ユーザ名
            string strPassword = "ProxyPassword"; // string.Empty;  // (3)パスワード

            strProxyServer = "";


           
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            HttpClientHandler httpClientHandler = new HttpClientHandler();

            WebProxy webProxy = new WebProxy();

            if (strProxyServer == "")
            {
                httpClientHandler.Proxy = null;
            }
            else
            {
                Uri newUri = new Uri(strProxyServer);
                webProxy.Address = newUri;
                webProxy.Credentials = new NetworkCredential(strUserName, strPassword);
                httpClientHandler.Proxy = webProxy;
            }

            //  HttpClientクラスのインスタンス(client)を生成
            HttpClient client = new HttpClient(handler: httpClientHandler, disposeHandler: true);


           
            Kyori kyori = null;

            HttpResponseMessage response = await client.GetAsync(Url);

            if (response.IsSuccessStatusCode)
            {
                string strResponse = await response.Content.ReadAsStringAsync();
                kyori = JsonSerializer.Deserialize<Kyori>(strResponse);

            }
            return kyori;

        }


      


    }
}
