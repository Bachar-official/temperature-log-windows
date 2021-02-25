using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLog.Entity
{
    public class Measure
    {
        private long id { get; set; }
        private DateTime date { get; set; }
        private double temperature { get; set; }
        private double humidity { get; set; }

        public Measure() { }

        public Measure(long id, DateTime date, double temperature, double humidity)
        {
            this.id = id;
            this.date = date;
            this.temperature = temperature;
            this.humidity = humidity;
        }
    }
}
