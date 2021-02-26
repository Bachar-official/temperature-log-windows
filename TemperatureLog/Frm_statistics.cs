using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureLog.Entity;
using ZedGraph;

namespace TemperatureLog
{
    public partial class Frm_statistics : Form
    {
        List<Measure> measures = new List<Measure>();
        List<DateTime> times = new List<DateTime>();
        public Frm_statistics()
        {
            InitializeComponent();
            measures = Utils.getAllMeasures();
            times = Utils.graphTimes(measures);
            DrawGraph();
        }

        public void DrawGraph()
        {
            PointPairList tempPoints;
            PointPairList humiPoints;
            LineItem tempCurve;

            var pane = graph.GraphPane;
            pane.CurveList.Clear();
            pane.XAxis.Type = ZedGraph.AxisType.Date;

            tempPoints = new PointPairList();
            humiPoints = new PointPairList();
            tempCurve = pane.AddCurve("Температура", tempPoints, Color.Orange, SymbolType.None);
            tempCurve = pane.AddCurve("Влажность", humiPoints, Color.Blue, SymbolType.None);

            for(int i = 0; i < times.Count; i++)
            {
                tempPoints.Add(new XDate(times[i]), measures[i].temperature);
                humiPoints.Add(new XDate(times[i]), measures[i].humidity);
            }
            graph.AxisChange();
            graph.Invalidate();
        }
    }
}
