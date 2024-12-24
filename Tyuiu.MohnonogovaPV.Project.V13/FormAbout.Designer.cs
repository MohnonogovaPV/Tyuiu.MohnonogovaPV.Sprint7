namespace Tyuiu.MohnonogovaPV.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_LAV = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelInfo_LAV
            // 
            labelInfo_LAV.AutoSize = true;
            labelInfo_LAV.Location = new Point(294, 12);
            labelInfo_LAV.Margin = new Padding(4, 0, 4, 0);
            labelInfo_LAV.Name = "labelInfo_LAV";
            labelInfo_LAV.Size = new Size(387, 220);
            labelInfo_LAV.TabIndex = 2;
            labelInfo_LAV.Text = resources.GetString("labelInfo_LAV.Text");
            labelInfo_LAV.Click += labelInfo_LAV_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Location = new Point(587, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(694, 323);
            Controls.Add(button1);
            Controls.Add(labelInfo_LAV);
            MaximizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelInfo_LAV;
        private Button button1;
    }
}