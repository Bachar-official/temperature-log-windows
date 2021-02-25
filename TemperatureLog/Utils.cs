using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureLog.Entity;

namespace TemperatureLog
{
    public static class Utils
    {
        public static string getInfo(string url)
        {
            WebRequest reqGET = WebRequest.Create(new Uri(url));
            WebResponse resp = reqGET.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            return s;
        }

        public static Measure getLastMeasure()
        {
            string json = "";
            Measure measure = new Measure();
            try
            {
                json = Utils.getInfo(Properties.Settings.Default.API_URL + "/measures/last");
                json = json.Trim('[');
                json = json.Trim(']');
                JavaScriptSerializer js = new JavaScriptSerializer();
                measure = js.Deserialize<Measure>(json);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при обращении по адресу " + Properties.Settings.Default.API_URL + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return measure;
        }
    }
}
