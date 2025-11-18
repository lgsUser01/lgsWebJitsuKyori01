using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace lgsWebJitsuKyori01.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KController : ControllerBase
    {

        lgsTrkSvr2NETX1.lgsTrkSvr2NETX1 TRKSVR2NETX1 = new lgsTrkSvr2NETX1.lgsTrkSvr2NETX1();

        [HttpGet]
        public string Get()
        {



            string Query = this.Request.GetDisplayUrl().ToString();



            // ?の位置 20190528
            int Pos = Query.IndexOf("?");
            Query = Query.Substring(Pos, Query.Length - Pos);

            // URL デコードする
            Query = System.Web.HttpUtility.UrlDecode(Query);

            Query = Query.Substring(1, Query.Length - 1);
            var dic = new Dictionary<string, string>();
            var apair = Query.Split('&');
            foreach (string strpair in apair)
            {
                var tpair = strpair.Split('=');
                dic.Add(tpair[0], tpair[1]);
            }



            string Kiten = String.Empty;
            try
            {
                Kiten = dic["f"];
            }
            catch
            {

            }

            string Shuuten = String.Empty;
            try
            {
                Shuuten = dic["t"];
            }
            catch
            {

            }

            //---------------------------------------------
            Boolean blnReceive = false;
            Boolean blnKeisanStat = false;
            string strKyoriMeter = "";
            int intMeter = 0;

            TRKSVR2NETX1.ServerComputerName = @"MR8400\lgstrksvr";
            TRKSVR2NETX1.KeisanJouken = 272;

            Boolean blnCond = TRKSVR2NETX1.lgsServerConnect();
            if (blnCond)
            {
                TRKSVR2NETX1.Kiten = Kiten;
                TRKSVR2NETX1.Shuuten = Shuuten;

                long lngIraiNo = (long)TRKSVR2NETX1.Request();
                do
                {
                    blnReceive = (bool)TRKSVR2NETX1.Reply(lngIraiNo, ref blnKeisanStat);
                    System.Threading.Thread.Sleep(1);
                } while (blnReceive == false);
                if (blnKeisanStat == true)
                {
                    intMeter = TRKSVR2NETX1.KyoriM;
                    strKyoriMeter = this.lgsKyoriMeterJson(intMeter);

                }
            }
            return strKyoriMeter;



        }


        public class Kyori
        {
            public int KyoriMeter { get; set; }
        }

        private string lgsKyoriMeterJson(int iMeter)
        {
            var kyori = new Kyori
            {
                KyoriMeter = iMeter
            };
            string strJson = JsonSerializer.Serialize(kyori);
            return strJson;
        }

    }



}
