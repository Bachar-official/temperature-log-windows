using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureLog
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            trayIcon.Visible = false;
            this.trayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            this.Resize += Frm_main_Resize;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 300000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Properties.Settings.Default.showNotifications)
            {
                trayIcon.ShowBalloonTip(2000, "Новое имерение", "Температура, влажность", ToolTipIcon.Info);
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
    }
}
