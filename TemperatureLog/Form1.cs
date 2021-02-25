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

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
