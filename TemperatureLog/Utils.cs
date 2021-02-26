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

        public static List<Measure> getAllMeasures()
        {
            string json = "";
            List<Measure> result = new List<Measure>();
            try
            {
                json = Utils.getInfo(Properties.Settings.Default.API_URL + "/measures");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при обращении по адресу " + Properties.Settings.Default.API_URL + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            result = js.Deserialize<List<Measure>>(json);
            return result;
        }

        public static List<Measure> getMeasuresFromFile(string path)
        {
            string json = "";
            List<Measure> result = new List<Measure>();
            try
            {
                json = File.ReadAllText(path);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ошибка при чтении файла \n" + Properties.Settings.Default.API_URL + exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            result = js.Deserialize<List<Measure>>(json);
            return result;
        }

        public static DateTime stringToDateTime(string str)
        {
            string[] strArray = str.Split(' ');
            List<int> timeDigits = timeArray(strArray[3]);
            return new DateTime(int.Parse(strArray[5]), monthToDigit(strArray[1]), int.Parse(strArray[2]), timeDigits[0],
                timeDigits[1], timeDigits[2]);
        }

        public static List<DateTime> graphTimes(List<Measure> measures)
        {
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < measures.Count; i++)
            {
                result.Add(stringToDateTime(measures[i].date));
            }
            return result;
        }

        public static int monthToDigit(string month)
        {
            switch(month)
            {
                case "Jan": return 1;
                case "Feb": return 2;
                case "Mar": return 3;
                case "Apr": return 4;
                case "May": return 5;
                case "Jun": return 6;
                case "Jul": return 7;
                case "Aug": return 8;
                case "Sep": return 9;
                case "Oct": return 10;
                case "Nov": return 11;
                case "Dec": return 12;
                default: return 0;
            }
        }

        public static List<int> timeArray(string time)
        {
            List<int> result = new List<int>();
            string[] timeArray = time.Split(':');
            for(int i = 0; i < timeArray.Length; i++)
            {
                result.Add(int.Parse(timeArray[i]));
            }
            return result;
        }
    }
}
