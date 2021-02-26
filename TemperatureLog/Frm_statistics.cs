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
            graph.GraphPane.Title.Text = "Данные";
            cmb_timecut.Text = "Все";
        }

        public void DrawGraph()
        {
            PointPairList tempPoints;
            PointPairList humiPoints;
            LineItem tempCurve;

            var pane = graph.GraphPane;
            pane.CurveList.Clear();
            pane.XAxis.Type = ZedGraph.AxisType.Date;
            pane.XAxis.Title.Text = "Время";
            pane.YAxis.Title.Text = "Влажность, температура";

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

        private void btn_file_Click(object sender, EventArgs e)
        {
            graph.GraphPane.Title.Text = "Данные из файла";
            string path = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы|*.txt";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                measures = Utils.getMeasuresFromFile(path);
                times = Utils.graphTimes(measures);
                DrawGraph();
            }
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                measures = Utils.getAllMeasures(cmb_timecut.Text);
                switch(cmb_timecut.Text)
                {
                    case "Все": graph.GraphPane.Title.Text = "Все данные"; break;
                    case "Сутки": graph.GraphPane.Title.Text = "Данные за сутки"; break;
                    case "Час": graph.GraphPane.Title.Text = "Данные за час"; break;
                    default: break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            times = Utils.graphTimes(measures);
            DrawGraph();
        }
    }
}
