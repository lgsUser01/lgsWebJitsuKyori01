using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lgsCallSocket01
{
    public partial class Form1 : Form
    {
       

        //public string lgsShouhinText { get; set; }
        public Form1()
        {
            InitializeComponent();

            this.lgsInit01();
        }
       

        private void lgsInit01()
        {
            this.textBox送信.Text = "272,13101,27127";

            this.textBox接続先.Text = "192.168.11.24"; /// 【1】接続先IPアドレス

        }




        private void button送信_Click_1(object sender, EventArgs e)
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[4096]; //1024

            // Connect to a remote device.
            try
            {

                string hostname = this.textBox接続先.Text; 

                IPHostEntry ipHostInfo = Dns.GetHostEntry(hostname);

                int intLength = ipHostInfo.AddressList.Length;
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                string strAddress = "";
                for (int i = 0; i < intLength; i++)
                {
                    strAddress = ipHostInfo.AddressList[i].ToString();
                    if (strAddress == hostname)
                    {
                        ipAddress = ipHostInfo.AddressList[i];
                        break;
                    }
                }



                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 44963);

             // Create a TCP/IP  socket.
                Socket sender1 = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender1.Connect(remoteEP);

                    Debug.WriteLine("Socket connected to {0}",
                        sender1.RemoteEndPoint.ToString());




              
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");

                    this.textBox受信.Text = "";


                    string strCom = this.textBox送信.Text; // = strCom;

                    byte[] msg = sjisEnc.GetBytes(strCom);
                    // Send the data through the socket.

                    int bytesSent = sender1.Send(msg);





                    // Receive the response from the remote device.
                    int bytesRec = sender1.Receive(bytes);

                    Debug.WriteLine("Echoed test = {0}",
                        sjisEnc.GetString(bytes, 0, bytesRec));

                    this.textBox受信.Text = sjisEnc.GetString(bytes, 0, bytesRec); // Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    string strKekka = this.textBox受信.Text;
           
                    

                    // Release the socket.
                    sender1.Shutdown(SocketShutdown.Both);
                    sender1.Close();

                }
                catch (ArgumentNullException ane)
                {
                    //Debug.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    MessageBox.Show("ArgumentNullException : {0}", ane.Message);
                    Environment.Exit(1); // 20190921
                }
                catch (SocketException se)
                {
                    //Debug.WriteLine("SocketException : {0}", se.ToString());
                    MessageBox.Show("SocketException : {0}", se.Message);
                    Environment.Exit(1); // 20190921
                }
                catch (Exception ex)
                {
                    //Debug.WriteLine("Unexpected exception : {0}", ex.ToString());
                    MessageBox.Show("Unexpected exception : {0}", ex.Message);
                    Environment.Exit(1); // 20190921
                }

            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
                Environment.Exit(1); // 20190921
            }
        }

       


        private void button受信クリア_Click_1(object sender, EventArgs e)
        {
            this.textBox受信.Text = "";
        }
    }

}
