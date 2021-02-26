using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureLog.Entity;
using System.Web;
using Nancy.Json;

namespace TemperatureLog
{
    public partial class Frm_main : Form
    {
        public Measure measure;
        System.Timers.Timer timer;
        public Frm_main()
        {
            InitializeComponent();
            trayIcon.Visible = false;
            this.trayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            this.Resize += Frm_main_Resize;
            timer = new System.Timers.Timer();
            timer.Interval = Properties.Settings.Default.notificationMinutes * 60000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            RefreshData();
            if (Properties.Settings.Default.showNotifications)
            {                
                trayIcon.ShowBalloonTip(2000, "Новое имерение", String.Format("Температура : {0}°C, влажность: {1}%", measure.temperature, measure.humidity), ToolTipIcon.Info);
            }            
        }

        private void Frm_main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void menuItemMinimize_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            Frm_settings settings = new Frm_settings();
            settings.ShowDialog();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_statistics statistics = new Frm_statistics();
            statistics.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            measure = Utils.getLastMeasure();
            degreesText.Text = measure.temperature.ToString();
            humidityText.Text = measure.humidity.ToString();
            trayIcon.Text = String.Format("Температура : {0}°C, влажность: {1}%", measure.temperature, measure.humidity);
        }

        private void btn_refresh_timer_Click(object sender, EventArgs e)
        {
            RefreshData();
            timer.Start();
        }
    }
}
