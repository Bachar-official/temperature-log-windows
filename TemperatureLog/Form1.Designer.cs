
namespace TemperatureLog
{
    partial class Frm_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.degreesText = new System.Windows.Forms.Label();
            this.degrees_label = new System.Windows.Forms.Label();
            this.humidity_percents = new System.Windows.Forms.Label();
            this.humidityText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Текущая погода";
            this.trayIcon.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(110, 26);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(109, 22);
            this.menuItemExit.Text = "Выход";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // degreesText
            // 
            this.degreesText.AutoSize = true;
            this.degreesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreesText.Location = new System.Drawing.Point(29, 41);
            this.degreesText.Name = "degreesText";
            this.degreesText.Size = new System.Drawing.Size(158, 73);
            this.degreesText.TabIndex = 1;
            this.degreesText.Text = "25.7";
            // 
            // degrees_label
            // 
            this.degrees_label.AutoSize = true;
            this.degrees_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degrees_label.Location = new System.Drawing.Point(172, 41);
            this.degrees_label.Name = "degrees_label";
            this.degrees_label.Size = new System.Drawing.Size(104, 73);
            this.degrees_label.TabIndex = 2;
            this.degrees_label.Text = "°C";
            // 
            // humidity_percents
            // 
            this.humidity_percents.AutoSize = true;
            this.humidity_percents.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidity_percents.Location = new System.Drawing.Point(192, 128);
            this.humidity_percents.Name = "humidity_percents";
            this.humidity_percents.Size = new System.Drawing.Size(89, 73);
            this.humidity_percents.TabIndex = 4;
            this.humidity_percents.Text = "%";
            // 
            // humidityText
            // 
            this.humidityText.AutoSize = true;
            this.humidityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidityText.Location = new System.Drawing.Point(29, 128);
            this.humidityText.Name = "humidityText";
            this.humidityText.Size = new System.Drawing.Size(158, 73);
            this.humidityText.TabIndex = 3;
            this.humidityText.Text = "00.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSettings,
            this.menuItemMinimize});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(134, 22);
            this.menuItemSettings.Text = "Настройки";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // menuItemMinimize
            // 
            this.menuItemMinimize.Name = "menuItemMinimize";
            this.menuItemMinimize.Size = new System.Drawing.Size(134, 22);
            this.menuItemMinimize.Text = "Свернуть";
            this.menuItemMinimize.Click += new System.EventHandler(this.menuItemMinimize_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 239);
            this.Controls.Add(this.humidity_percents);
            this.Controls.Add(this.humidityText);
            this.Controls.Add(this.degrees_label);
            this.Controls.Add(this.degreesText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_main";
            this.Text = "Текущая погода";
            this.contextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label degreesText;
        private System.Windows.Forms.Label degrees_label;
        private System.Windows.Forms.Label humidity_percents;
        private System.Windows.Forms.Label humidityText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemMinimize;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

