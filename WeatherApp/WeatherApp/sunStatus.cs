using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Xml;
using static WeatherApp.apiKey;

namespace WeatherApp
{
    public partial class sunStatus : UserControl
    {
        string date = DateTime.Now.ToString("yyyyMMdd");
        bool isVisible;
        public sunStatus()
        {
            InitializeComponent();
            getAPI();
            xmlCode.Hide();
            sunStatusPanel.BringToFront();
            isVisible = true;
        }

        public void getAPI()
        {
            
            string query = "http://apis.data.go.kr/B090041/openapi/service/RiseSetInfoService/getAreaRiseSetInfo?location=%EC%84%9C%EC%9A%B8&locdate=" +
                date + "&ServiceKey=" + Confidentials.ApiKey;
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
            for(int i = 0; i < node.ChildNodes.Count; i++)
            {
                string sunrisestring = node.ChildNodes[i]["sunrise"].InnerText;
                string sunsetstring = node.ChildNodes[i]["sunset"].InnerText;
                location.Text = node.ChildNodes[i]["location"].InnerText;
                dateTime.Text = node.ChildNodes[i]["locdate"].InnerText;
                longitude.Text = node.ChildNodes[i]["longitudeNum"].InnerText;
                latitude.Text = node.ChildNodes[i]["latitude"].InnerText;
                sunrise.Text = sunrisestring;
                sunset.Text = sunsetstring;
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
            else if(isVisible == false)
            {
                xmlCode.Hide();
                sunStatusPanel.BringToFront();
                isVisible = true;
            }
        }
    }
}
