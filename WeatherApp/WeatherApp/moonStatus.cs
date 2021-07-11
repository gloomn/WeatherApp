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
using System.Windows.Forms;
using System.Xml;
using static WeatherApp.apiKey;

namespace WeatherApp
{
    public partial class moonStatus : UserControl
    {
        string date = DateTime.Now.ToString("yyyyMMdd");//오늘 날짜
        bool isVisible;
        public moonStatus()
        {
            InitializeComponent();
            getAPI();
            xmlCode.Hide();
            moonStatusPanel.BringToFront();
            isVisible = true;
        }

        public void getAPI()
        {

            string query = "http://apis.data.go.kr/B090041/openapi/service/RiseSetInfoService/getAreaRiseSetInfo?location=%EC%84%9C%EC%9A%B8&locdate=" +
                date + "&ServiceKey=" + Confidentials.moonStatusApiKey;
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
                string sunriseString = node.ChildNodes[i]["moonrise"].InnerText;
                string sunsetString = node.ChildNodes[i]["moonset"].InnerText;
                string dateTimeString = node.ChildNodes[i]["locdate"].InnerText;
                location.Text = node.ChildNodes[i]["location"].InnerText;
                dateTime.Text = dateTimeString.Substring(0, 4) + "년 " + dateTimeString.Substring(4, 2) +
                    "월 " + dateTimeString.Substring(6, 2) + "일";
                longitude.Text = node.ChildNodes[i]["longitudeNum"].InnerText;
                latitude.Text = node.ChildNodes[i]["latitudeNum"].InnerText;
                moonrise.Text = sunriseString.Substring(0, 2) + "시 " + sunriseString.Substring(2, 2) + "분";
                moonset.Text = sunsetString.Substring(0, 2) + "시 " + sunsetString.Substring(2, 2) + "분";
            }
        }

        private void showXmlCode_Click(object sender, EventArgs e)
        {
            if (isVisible == true)
            {
                xmlCode.Show();
                xmlCode.BringToFront();
                isVisible = false;
            }
            else if (isVisible == false)
            {
                xmlCode.Hide();
                moonStatusPanel.BringToFront();
                isVisible = true;
            }
        }
    }
}
