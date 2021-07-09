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

namespace WeatherApp
{
    public partial class sunStatus : UserControl
    {
        public sunStatus()
        {
            InitializeComponent();
        }

        public void getAPI()
        {
            string query = "";
            WebRequest request = WebRequest.Create(query);
        }
        

    }
}
