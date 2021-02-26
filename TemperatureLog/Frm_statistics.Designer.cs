
namespace TemperatureLog
{
    partial class Frm_statistics
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
            this.components = new System.ComponentModel.Container();
            this.graph = new ZedGraph.ZedGraphControl();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.cmb_timecut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(12, 12);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(688, 383);
            this.graph.TabIndex = 0;
            this.graph.UseExtendedPrintDialog = true;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(575, 401);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(125, 23);
            this.btn_file.TabIndex = 1;
            this.btn_file.Text = "Открыть из файла...";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(464, 401);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(105, 23);
            this.btn_get.TabIndex = 2;
            this.btn_get.Text = "Получить данные";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // cmb_timecut
            // 
            this.cmb_timecut.FormattingEnabled = true;
            this.cmb_timecut.Items.AddRange(new object[] {
            "Все",
            "Сутки",
            "Час"});
            this.cmb_timecut.Location = new System.Drawing.Point(348, 401);
            this.cmb_timecut.Name = "cmb_timecut";
            this.cmb_timecut.Size = new System.Drawing.Size(110, 21);
            this.cmb_timecut.TabIndex = 3;
            // 
            // Frm_statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 435);
            this.Controls.Add(this.cmb_timecut);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_statistics";
            this.Text = "Статистика";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.ComboBox cmb_timecut;
    }
}