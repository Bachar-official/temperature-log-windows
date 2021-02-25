
namespace TemperatureLog
{
    partial class Frm_settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_url = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.check_showNotifications = new System.Windows.Forms.CheckBox();
            this.num_minutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL и порт API:";
            // 
            // tbox_url
            // 
            this.tbox_url.Location = new System.Drawing.Point(16, 30);
            this.tbox_url.Name = "tbox_url";
            this.tbox_url.Size = new System.Drawing.Size(287, 20);
            this.tbox_url.TabIndex = 1;
            this.tbox_url.TextChanged += new System.EventHandler(this.tbox_url_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(227, 196);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Закрыть";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(146, 196);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // check_showNotifications
            // 
            this.check_showNotifications.AutoSize = true;
            this.check_showNotifications.Location = new System.Drawing.Point(16, 57);
            this.check_showNotifications.Name = "check_showNotifications";
            this.check_showNotifications.Size = new System.Drawing.Size(202, 17);
            this.check_showNotifications.TabIndex = 4;
            this.check_showNotifications.Text = "Показывать уведомления каждые";
            this.check_showNotifications.UseVisualStyleBackColor = true;
            this.check_showNotifications.CheckedChanged += new System.EventHandler(this.check_showNotifications_CheckedChanged);
            // 
            // num_minutes
            // 
            this.num_minutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_minutes.Location = new System.Drawing.Point(219, 56);
            this.num_minutes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_minutes.Name = "num_minutes";
            this.num_minutes.Size = new System.Drawing.Size(40, 20);
            this.num_minutes.TabIndex = 5;
            this.num_minutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_minutes.ValueChanged += new System.EventHandler(this.num_minutes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "минут";
            // 
            // Frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_minutes);
            this.Controls.Add(this.check_showNotifications);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tbox_url);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_settings";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.num_minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_url;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox check_showNotifications;
        private System.Windows.Forms.NumericUpDown num_minutes;
        private System.Windows.Forms.Label label2;
    }
}