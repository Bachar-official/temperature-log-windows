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
    public partial class Frm_settings : Form
    {
        public Frm_settings()
        {
            InitializeComponent();
            check_showNotifications.Checked = Properties.Settings.Default.showNotifications;
            tbox_url.Text = Properties.Settings.Default.API_URL;
        }

        private void check_showNotifications_CheckedChanged(object sender, EventArgs e)
        {
            bool showNotifications = check_showNotifications.Checked;
            num_minutes.Enabled = showNotifications;
            Properties.Settings.Default.showNotifications = showNotifications;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num_minutes_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.notificationMinutes = (int)num_minutes.Value;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("Настройки сохранены", "Сохранить", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbox_url_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.API_URL = tbox_url.Text;
        }
    }
}
