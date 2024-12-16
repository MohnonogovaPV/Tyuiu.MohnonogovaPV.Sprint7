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
            pictureBoxInfo_LAV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_LAV).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_LAV
            // 
            labelInfo_LAV.AutoSize = true;
            labelInfo_LAV.Location = new Point(298, 12);
            labelInfo_LAV.Margin = new Padding(4, 0, 4, 0);
            labelInfo_LAV.Name = "labelInfo_LAV";
            labelInfo_LAV.Size = new Size(387, 220);
            labelInfo_LAV.TabIndex = 2;
            labelInfo_LAV.Text = resources.GetString("labelInfo_LAV.Text");
            labelInfo_LAV.Click += labelInfo_LAV_Click;
            // 
            // pictureBoxInfo_LAV
            // 
            pictureBoxInfo_LAV.Image = (Image)resources.GetObject("pictureBoxInfo_LAV.Image");
            pictureBoxInfo_LAV.Location = new Point(12, 12);
            pictureBoxInfo_LAV.Name = "pictureBoxInfo_LAV";
            pictureBoxInfo_LAV.Size = new Size(256, 285);
            pictureBoxInfo_LAV.TabIndex = 0;
            pictureBoxInfo_LAV.TabStop = false;
            pictureBoxInfo_LAV.Click += pictureBoxInfo_LAV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 323);
            Controls.Add(labelInfo_LAV);
            Controls.Add(pictureBoxInfo_LAV);
            MaximizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_LAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelInfo_LAV;
        private PictureBox pictureBoxInfo_LAV;
    }
}