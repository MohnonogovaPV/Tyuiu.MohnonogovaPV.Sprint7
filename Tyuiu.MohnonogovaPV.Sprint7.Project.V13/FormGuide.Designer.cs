namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13
{
    partial class FormGuide
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
            buttonOkGuide_MPV = new Button();
            labelGuide_MPV = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonOkGuide_MPV
            // 
            buttonOkGuide_MPV.Location = new Point(782, 444);
            buttonOkGuide_MPV.Margin = new Padding(4, 5, 4, 5);
            buttonOkGuide_MPV.Name = "buttonOkGuide_MPV";
            buttonOkGuide_MPV.Size = new Size(131, 54);
            buttonOkGuide_MPV.TabIndex = 1;
            buttonOkGuide_MPV.Text = "OK";
            buttonOkGuide_MPV.UseVisualStyleBackColor = true;
            buttonOkGuide_MPV.Click += buttonOkGuide_MPV_Click;
            // 
            // labelGuide_MPV
            // 
            labelGuide_MPV.AutoSize = true;
            labelGuide_MPV.Location = new Point(3, 14);
            labelGuide_MPV.Margin = new Padding(4, 0, 4, 0);
            labelGuide_MPV.Name = "labelGuide_MPV";
            labelGuide_MPV.Size = new Size(0, 20);
            labelGuide_MPV.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Location = new Point(36, 14);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(865, 407);
            textBox1.TabIndex = 3;
            textBox1.Text = "Данная программа помогает найти пользователям информацию о странах мира, а именно:\r\n\r\n\r\nстолица\r\n\r\nплощадь территории\r\n\r\nразвитость\r\n\r\nнаселение\r\n\r\nпреобладающая национальность\r\n\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(945, 511);
            Controls.Add(textBox1);
            Controls.Add(labelGuide_MPV);
            Controls.Add(buttonOkGuide_MPV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonOkGuide_MPV;
        private System.Windows.Forms.Label labelGuide_MPV;
        private TextBox textBox1;
    }
}