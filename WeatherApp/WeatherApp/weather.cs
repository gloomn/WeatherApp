using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using static WeatherApp.apiKey;

namespace WeatherApp
{
    public partial class weather : UserControl
    {
        string date = DateTime.Now.ToString("yyyyMMdd");
        string time = DateTime.Now.ToString("hhmm");
        public weather()
        {
            InitializeComponent();
        }

        public void getAPI()
        {
            string query = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0/getVilageFcst?serviceKey=" +
                Confidentials.weatherApiKey + "&numOfRows=10&pageNo=1&base_date=20210628&base_time=0500&nx=55&ny=127";
            WebRequest request = WebRequest.Create(query);
            request.Method = "GET";

            WebResponse webresponse = request.GetResponse();
            Stream stream = webresponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string response = reader.ReadToEnd();
            xmlCode.Text = response;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            XmlNode node = doc["response"]["body"]["items"];
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
            }
        }
    }
}
