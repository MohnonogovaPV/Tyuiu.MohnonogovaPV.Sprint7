
namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStats_MPV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDevelop_MPV = new System.Windows.Forms.Button();
            this.buttonNational_MPV = new System.Windows.Forms.Button();
            this.groupBoxStats_MPV = new System.Windows.Forms.GroupBox();
            this.labelAverageArea_MPV = new System.Windows.Forms.Label();
            this.textBoxAverageArea_MPV = new System.Windows.Forms.TextBox();
            this.labelAveragePopulation_MPV = new System.Windows.Forms.Label();
            this.textBoxAveragePopulation_MPV = new System.Windows.Forms.TextBox();
            this.buttonViewStats_MPV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_MPV)).BeginInit();
            this.groupBoxStats_MPV.SuspendLayout();
            this.SuspendLayout();
            //
            // chartStats_MPV
            //
            this.chartStats_MPV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartStats_MPV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartStats_MPV.Legends.Add(legend1);
            this.chartStats_MPV.Location = new System.Drawing.Point(256, 12);
            this.chartStats_MPV.Name = "chartStats_MPV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats_MPV.Series.Add(series1);
            this.chartStats_MPV.Size = new System.Drawing.Size(532, 329);
            this.chartStats_MPV.TabIndex = 0;
            this.chartStats_MPV.Text = "chart1";
            //
            // buttonDevelop_MPV
            //
            this.buttonDevelop_MPV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDevelop_MPV.Location = new System.Drawing.Point(12, 12);
            this.buttonDevelop_MPV.Name = "buttonDevelop_MPV";
            this.buttonDevelop_MPV.Size = new System.Drawing.Size(238, 162);
            this.buttonDevelop_MPV.TabIndex = 1;
            this.buttonDevelop_MPV.Text = "График \r\n\"Кол-во стран/является ли страна развитой\"";
            this.buttonDevelop_MPV.UseVisualStyleBackColor = true;
            this.buttonDevelop_MPV.Click += new System.EventHandler(this.buttonDevelop_MPV_Click);
            //
            // buttonNational_MPV
            //

           
this.buttonNational_MPV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNational_MPV.Location = new System.Drawing.Point(12, 179);
            this.buttonNational_MPV.Name = "buttonNational_MPV";
            this.buttonNational_MPV.Size = new System.Drawing.Size(238, 162);
            this.buttonNational_MPV.TabIndex = 2;
            this.buttonNational_MPV.Text = "График \r\n\"Кол-во стран/преобладающая национальность\"";
            this.buttonNational_MPV.UseVisualStyleBackColor = true;
            this.buttonNational_MPV.Click += new System.EventHandler(this.buttonNational_MPV_Click);
            //
            // groupBoxStats_MPV
            //
            this.groupBoxStats_MPV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStats_MPV.Controls.Add(this.labelAverageArea_MPV);
            this.groupBoxStats_MPV.Controls.Add(this.textBoxAverageArea_MPV);
            this.groupBoxStats_MPV.Controls.Add(this.labelAveragePopulation_MPV);
            this.groupBoxStats_MPV.Controls.Add(this.textBoxAveragePopulation_MPV);
            this.groupBoxStats_MPV.Controls.Add(this.buttonViewStats_MPV);
            this.groupBoxStats_MPV.Location = new System.Drawing.Point(12, 347);
            this.groupBoxStats_MPV.Name = "groupBoxStats_MPV";
            this.groupBoxStats_MPV.Size = new System.Drawing.Size(776, 136);
            this.groupBoxStats_MPV.TabIndex = 3;
            this.groupBoxStats_MPV.TabStop = false;
            this.groupBoxStats_MPV.Text = "Статистика";
            //
            // labelAverageArea_MPV
            //
            this.labelAverageArea_MPV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAverageArea_MPV.AutoSize = true;
            this.labelAverageArea_MPV.Location = new System.Drawing.Point(293, 18);
            this.labelAverageArea_MPV.Name = "labelAverageArea_MPV";
            this.labelAverageArea_MPV.Size = new System.Drawing.Size(280, 17);
            this.labelAverageArea_MPV.TabIndex = 4;
            this.labelAverageArea_MPV.Text = "Ср. значение площади территории, км^2";
            //
            // textBoxAverageArea_MPV
            //
            this.textBoxAverageArea_MPV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAverageArea_MPV.Location = new System.Drawing.Point(296, 38);
            this.textBoxAverageArea_MPV.Name = "textBoxAverageArea_MPV";
            this.textBoxAverageArea_MPV.ReadOnly = true;
            this.textBoxAverageArea_MPV.Size = new System.Drawing.Size(277, 22);
            this.textBoxAverageArea_MPV.TabIndex = 3;
            //
            // labelAveragePopulation_MPV
            //
            this.labelAveragePopulation_MPV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAveragePopulation_MPV.AutoSize = true;
            this.labelAveragePopulation_MPV.Location = new System.Drawing.Point(293, 63);
            this.labelAveragePopulation_MPV.Name = "labelAveragePopulation_MPV";
            this.labelAveragePopulation_MPV.Size = new System.Drawing.Size(252, 17);
            this.labelAveragePopulation_MPV.TabIndex = 2;
            this.labelAveragePopulation_MPV.Text = "Ср. Значение кол-ва населения, чел\r\n";
            //
            // textBoxAveragePopulation_MPV
            //
            this.textBoxAveragePopulation_MPV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAveragePopulation_MPV.Location = new System.Drawing.Point(296, 83);
            this.textBoxAveragePopulation_MPV.Name = "textBoxAveragePopulation_MPV";
            this.textBoxAveragePopulation_MPV.ReadOnly = true;
            this.textBoxAveragePopulation_MPV.Size = new System.Drawing.Size(277, 22);
            this.textBoxAveragePopulation_MPV.TabIndex = 1;
            //
            // buttonViewStats_MPV
            //
            this.buttonViewStats_MPV.Location = new System.Drawing.Point(3, 18);

            
this.buttonViewStats_MPV.Name = "buttonViewStats_MPV";
            this.buttonViewStats_MPV.Size = new System.Drawing.Size(102, 112);
            this.buttonViewStats_MPV.TabIndex = 0;
            this.buttonViewStats_MPV.Text = "Отобразить статистику";
            this.buttonViewStats_MPV.UseVisualStyleBackColor = true;
            this.buttonViewStats_MPV.Click += new System.EventHandler(this.buttonViewStats_MPV_Click);
            //
            // FormStats
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.groupBoxStats_MPV);
            this.Controls.Add(this.buttonNational_MPV);
            this.Controls.Add(this.buttonDevelop_MPV);
            this.Controls.Add(this.chartStats_MPV);
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистические данные";
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_MPV)).EndInit();
            this.groupBoxStats_MPV.ResumeLayout(false);
            this.groupBoxStats_MPV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_MPV;
        private System.Windows.Forms.Button buttonDevelop_MPV;
        private System.Windows.Forms.Button buttonNational_MPV;
        private System.Windows.Forms.GroupBox groupBoxStats_MPV;
        private System.Windows.Forms.Label labelAverageArea_MPV;
        private System.Windows.Forms.TextBox textBoxAverageArea_MPV;
        private System.Windows.Forms.Label labelAveragePopulation_MPV;
        private System.Windows.Forms.TextBox textBoxAveragePopulation_MPV;
        private System.Windows.Forms.Button buttonViewStats_MPV;
    }
}