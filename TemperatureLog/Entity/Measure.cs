using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text.Json.Serialization;

namespace TemperatureLog.Entity
{
    [Serializable]
    public class Measure
    {
        public long id { get; set; }
        public string date { get; set; }
        public double temperature { get; set; }
        public double humidity { get; set; }

        public Measure() { }

        public double getTemperature()
        {
            return this.temperature;
        }

        public double getHumidity()
        {
            return this.humidity;
        }
    }
}
