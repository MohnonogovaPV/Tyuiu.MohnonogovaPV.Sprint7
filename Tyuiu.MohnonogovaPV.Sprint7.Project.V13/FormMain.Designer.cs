
namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelName_MPV = new Label();
            panelTop_MPV = new Panel();
            buttonStats_MPV = new Button();
            buttonInfo_MPV = new Button();
            buttonOpen_MPV = new Button();
            openFileDialogMain_MPV = new OpenFileDialog();
            saveFileDialogMain_MPV = new SaveFileDialog();
            groupBoxData_MPV = new GroupBox();
            dataGridViewMain_MPV = new DataGridView();
            buttonAdd_MPV = new Button();
            buttonDelete_MPV = new Button();
            textBoxAddCountry_MPV = new TextBox();
            textBoxAddArea_MPV = new TextBox();
            textBoxAddCapital_MPV = new TextBox();
            textBoxAddNational_MPV = new TextBox();
            textBoxAddPopulation_MPV = new TextBox();
            radioButtonYes_MPV = new RadioButton();
            radioButtonNo_MPV = new RadioButton();
            labelCountry_MPV = new Label();
            labelAddCapital_MPV = new Label();
            labelAddArea_MPV = new Label();
            labelAddDevelop_MPV = new Label();
            labelAddPopulation_MPV = new Label();
            labelAddNational_MPV = new Label();
            groupBoxNewCountry_MPV = new GroupBox();
            groupBoxMain_MPV = new GroupBox();
            groupBoxSearch_MPV = new GroupBox();
            labelColumns_MPV = new Label();
            labelWhatSearch_MPV = new Label();
            textBoxColumns_MPV = new TextBox();
            textBoxWhatSearch_MPV = new TextBox();
            buttonSearch_MPV = new Button();
            groupBoxDelete_MPV = new GroupBox();
            labelDelete_MPV = new Label();
            textBoxDelete_MPV = new TextBox();
            groupBoxSort_MPV = new GroupBox();
            menuStrip1Sort_MPV = new MenuStrip();
            ToolStripMenuItemSortMax_MPV = new ToolStripMenuItem();
            ToolStripMenuItemAreaMax_MPV = new ToolStripMenuItem();
            ToolStripMenuItemPopulationMax_MPV = new ToolStripMenuItem();
            ToolStripMenuItemSortMin_MPV = new ToolStripMenuItem();
            ToolStripMenuItemAreaMin_MPV = new ToolStripMenuItem();
            ToolStripMenuItemPopulationMin_MPV = new ToolStripMenuItem();
            toolTipInfo_MPV = new ToolTip(components);
            panelTop_MPV.SuspendLayout();
            groupBoxData_MPV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_MPV).BeginInit();
            groupBoxNewCountry_MPV.SuspendLayout();
            groupBoxMain_MPV.SuspendLayout();
            groupBoxSearch_MPV.SuspendLayout();
            groupBoxDelete_MPV.SuspendLayout();
            groupBoxSort_MPV.SuspendLayout();
            menuStrip1Sort_MPV.SuspendLayout();
            SuspendLayout();
            // 
            // labelName_MPV
            // 
            labelName_MPV.AutoSize = true;
            labelName_MPV.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName_MPV.ForeColor = Color.White;
            labelName_MPV.Location = new Point(4, 14);
            labelName_MPV.Margin = new Padding(4, 0, 4, 0);
            labelName_MPV.Name = "labelName_MPV";
            labelName_MPV.Size = new Size(543, 91);
            labelName_MPV.TabIndex = 0;
            labelName_MPV.Text = "ГЕОГРАФИЯ";
            // 
            // panelTop_MPV
            // 
            panelTop_MPV.BackColor = Color.Orange;
            panelTop_MPV.Controls.Add(buttonStats_MPV);
            panelTop_MPV.Controls.Add(labelName_MPV);
            panelTop_MPV.Controls.Add(buttonInfo_MPV);
            panelTop_MPV.Controls.Add(buttonOpen_MPV);
            panelTop_MPV.Dock = DockStyle.Top;
            panelTop_MPV.Location = new Point(0, 0);
            panelTop_MPV.Margin = new Padding(4, 5, 4, 5);
            panelTop_MPV.Name = "panelTop_MPV";
            panelTop_MPV.Size = new Size(1395, 154);
            panelTop_MPV.TabIndex = 0;
            // 
            // buttonStats_MPV
            // 
            buttonStats_MPV.Location = new Point(960, 14);
            buttonStats_MPV.Margin = new Padding(4, 5, 4, 5);
            buttonStats_MPV.Name = "buttonStats_MPV";
            buttonStats_MPV.Size = new Size(302, 114);
            buttonStats_MPV.TabIndex = 17;
            buttonStats_MPV.Text = "Статистические данные";
            buttonStats_MPV.UseVisualStyleBackColor = true;
            buttonStats_MPV.Click += buttonStats_MPV_Click;
            // 
            // buttonInfo_MPV
            // 
            buttonInfo_MPV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_MPV.Image = (Image)resources.GetObject("buttonInfo_MPV.Image");
            buttonInfo_MPV.Location = new Point(1293, 14);
            buttonInfo_MPV.Margin = new Padding(4, 5, 4, 5);
            buttonInfo_MPV.Name = "buttonInfo_MPV";
            buttonInfo_MPV.Size = new Size(93, 114);
            buttonInfo_MPV.TabIndex = 3;
            toolTipInfo_MPV.SetToolTip(buttonInfo_MPV, "О Программе");
            buttonInfo_MPV.UseVisualStyleBackColor = true;
            buttonInfo_MPV.Click += buttonInfo_MPV_Click;
            // 
            // buttonOpen_MPV
            // 
            buttonOpen_MPV.Image = (Image)resources.GetObject("buttonOpen_MPV.Image");
            buttonOpen_MPV.Location = new Point(798, 14);
            buttonOpen_MPV.Margin = new Padding(4, 5, 4, 5);
            buttonOpen_MPV.Name = "buttonOpen_MPV";
            buttonOpen_MPV.Size = new Size(136, 114);
            buttonOpen_MPV.TabIndex = 12;
            toolTipInfo_MPV.SetToolTip(buttonOpen_MPV, "Загрузить базу данных");
            buttonOpen_MPV.UseVisualStyleBackColor = true;
            buttonOpen_MPV.Click += buttonOpen_MPV_Click;
            // 
            // openFileDialogMain_MPV
            // 
            openFileDialogMain_MPV.FileName = "openFileDialog1";
            // 
            // groupBoxData_MPV
            // 
            groupBoxData_MPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxData_MPV.Controls.Add(dataGridViewMain_MPV);
            groupBoxData_MPV.Location = new Point(671, 228);
            groupBoxData_MPV.Margin = new Padding(3, 4, 3, 4);
            groupBoxData_MPV.Name = "groupBoxData_MPV";
            groupBoxData_MPV.Padding = new Padding(3, 4, 3, 4);
            groupBoxData_MPV.Size = new Size(712, 626);
            groupBoxData_MPV.TabIndex = 19;
            groupBoxData_MPV.TabStop = false;
            groupBoxData_MPV.Text = "Информация";
            // 
            // dataGridViewMain_MPV
            // 
            dataGridViewMain_MPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMain_MPV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain_MPV.ColumnHeadersVisible = false;
            dataGridViewMain_MPV.Location = new Point(6, 22);
            dataGridViewMain_MPV.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMain_MPV.Name = "dataGridViewMain_MPV";
            dataGridViewMain_MPV.RowHeadersVisible = false;
            dataGridViewMain_MPV.RowHeadersWidth = 51;
            dataGridViewMain_MPV.RowTemplate.Height = 24;
            dataGridViewMain_MPV.Size = new Size(700, 596);
            dataGridViewMain_MPV.TabIndex = 0;
            // 
            // buttonAdd_MPV
            // 
            buttonAdd_MPV.Location = new Point(518, 179);
            buttonAdd_MPV.Margin = new Padding(4, 5, 4, 5);
            buttonAdd_MPV.Name = "buttonAdd_MPV";
            buttonAdd_MPV.Size = new Size(100, 78);
            buttonAdd_MPV.TabIndex = 14;
            toolTipInfo_MPV.SetToolTip(buttonAdd_MPV, "Сохранить страну в базу данных");
            buttonAdd_MPV.UseVisualStyleBackColor = true;
            buttonAdd_MPV.Click += buttonAdd_MPV_Click;
            // 
            // buttonDelete_MPV
            // 
            buttonDelete_MPV.Location = new Point(518, 31);
            buttonDelete_MPV.Margin = new Padding(4, 5, 4, 5);
            buttonDelete_MPV.Name = "buttonDelete_MPV";
            buttonDelete_MPV.Size = new Size(100, 78);
            buttonDelete_MPV.TabIndex = 15;
            toolTipInfo_MPV.SetToolTip(buttonDelete_MPV, "Удалить страну из базы данных");
            buttonDelete_MPV.UseVisualStyleBackColor = true;
            buttonDelete_MPV.Click += buttonDelete_MPV_Click;
            // 
            // textBoxAddCountry_MPV
            // 
            textBoxAddCountry_MPV.Location = new Point(6, 49);
            textBoxAddCountry_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxAddCountry_MPV.Name = "textBoxAddCountry_MPV";
            textBoxAddCountry_MPV.Size = new Size(238, 27);
            textBoxAddCountry_MPV.TabIndex = 0;
            // 
            // textBoxAddArea_MPV
            // 
            textBoxAddArea_MPV.Location = new Point(383, 49);
            textBoxAddArea_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxAddArea_MPV.Name = "textBoxAddArea_MPV";
            textBoxAddArea_MPV.Size = new Size(226, 27);
            textBoxAddArea_MPV.TabIndex = 1;
            // 
            // textBoxAddCapital_MPV
            // 
            textBoxAddCapital_MPV.Location = new Point(250, 49);
            textBoxAddCapital_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxAddCapital_MPV.Name = "textBoxAddCapital_MPV";
            textBoxAddCapital_MPV.Size = new Size(127, 27);
            textBoxAddCapital_MPV.TabIndex = 2;
            // 
            // textBoxAddNational_MPV
            // 
            textBoxAddNational_MPV.Location = new Point(383, 105);
            textBoxAddNational_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxAddNational_MPV.Name = "textBoxAddNational_MPV";
            textBoxAddNational_MPV.Size = new Size(226, 27);
            textBoxAddNational_MPV.TabIndex = 3;
            // 
            // textBoxAddPopulation_MPV
            // 
            textBoxAddPopulation_MPV.Location = new Point(250, 105);
            textBoxAddPopulation_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPopulation_MPV.Name = "textBoxAddPopulation_MPV";
            textBoxAddPopulation_MPV.Size = new Size(127, 27);
            textBoxAddPopulation_MPV.TabIndex = 4;
            // 
            // radioButtonYes_MPV
            // 
            radioButtonYes_MPV.AutoSize = true;
            radioButtonYes_MPV.Location = new Point(6, 106);
            radioButtonYes_MPV.Margin = new Padding(3, 4, 3, 4);
            radioButtonYes_MPV.Name = "radioButtonYes_MPV";
            radioButtonYes_MPV.Size = new Size(48, 24);
            radioButtonYes_MPV.TabIndex = 6;
            radioButtonYes_MPV.TabStop = true;
            radioButtonYes_MPV.Text = "Да";
            radioButtonYes_MPV.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo_MPV
            // 
            radioButtonNo_MPV.AutoSize = true;
            radioButtonNo_MPV.Location = new Point(6, 140);
            radioButtonNo_MPV.Margin = new Padding(3, 4, 3, 4);
            radioButtonNo_MPV.Name = "radioButtonNo_MPV";
            radioButtonNo_MPV.Size = new Size(55, 24);
            radioButtonNo_MPV.TabIndex = 7;
            radioButtonNo_MPV.TabStop = true;
            radioButtonNo_MPV.Text = "Нет";
            radioButtonNo_MPV.UseVisualStyleBackColor = true;
            // 
            // labelCountry_MPV
            // 
            labelCountry_MPV.AutoSize = true;
            labelCountry_MPV.ImageAlign = ContentAlignment.TopRight;
            labelCountry_MPV.Location = new Point(6, 26);
            labelCountry_MPV.Name = "labelCountry_MPV";
            labelCountry_MPV.Size = new Size(134, 20);
            labelCountry_MPV.TabIndex = 8;
            labelCountry_MPV.Text = "Название страны:";
            // 
            // labelAddCapital_MPV
            // 
            labelAddCapital_MPV.AutoSize = true;
            labelAddCapital_MPV.Location = new Point(250, 26);
            labelAddCapital_MPV.Name = "labelAddCapital_MPV";
            labelAddCapital_MPV.Size = new Size(70, 20);
            labelAddCapital_MPV.TabIndex = 9;
            labelAddCapital_MPV.Text = "Столица:";
            // 
            // labelAddArea_MPV
            // 
            labelAddArea_MPV.AutoSize = true;
            labelAddArea_MPV.Location = new Point(383, 26);
            labelAddArea_MPV.Name = "labelAddArea_MPV";
            labelAddArea_MPV.Size = new Size(206, 20);
            labelAddArea_MPV.TabIndex = 10;
            labelAddArea_MPV.Text = "Площадь территории, км^2:";
            // 
            // labelAddDevelop_MPV
            // 
            labelAddDevelop_MPV.AutoSize = true;
            labelAddDevelop_MPV.Location = new Point(6, 80);
            labelAddDevelop_MPV.Name = "labelAddDevelop_MPV";
            labelAddDevelop_MPV.Size = new Size(146, 20);
            labelAddDevelop_MPV.TabIndex = 11;
            labelAddDevelop_MPV.Text = "Развитая ли страна:";
            // 
            // labelAddPopulation_MPV
            // 
            labelAddPopulation_MPV.AutoSize = true;
            labelAddPopulation_MPV.Location = new Point(250, 80);
            labelAddPopulation_MPV.Name = "labelAddPopulation_MPV";
            labelAddPopulation_MPV.Size = new Size(119, 20);
            labelAddPopulation_MPV.TabIndex = 12;
            labelAddPopulation_MPV.Text = "Население, чел:";
            // 
            // labelAddNational_MPV
            // 
            labelAddNational_MPV.AutoSize = true;
            labelAddNational_MPV.Location = new Point(383, 80);
            labelAddNational_MPV.Name = "labelAddNational_MPV";
            labelAddNational_MPV.Size = new Size(250, 20);
            labelAddNational_MPV.TabIndex = 13;
            labelAddNational_MPV.Text = "Преобладающая национальность:";
            // 
            // groupBoxNewCountry_MPV
            // 
            groupBoxNewCountry_MPV.Anchor = AnchorStyles.None;
            groupBoxNewCountry_MPV.Controls.Add(labelAddNational_MPV);
            groupBoxNewCountry_MPV.Controls.Add(labelAddPopulation_MPV);
            groupBoxNewCountry_MPV.Controls.Add(labelAddDevelop_MPV);
            groupBoxNewCountry_MPV.Controls.Add(labelAddArea_MPV);
            groupBoxNewCountry_MPV.Controls.Add(labelAddCapital_MPV);
            groupBoxNewCountry_MPV.Controls.Add(buttonAdd_MPV);
            groupBoxNewCountry_MPV.Controls.Add(labelCountry_MPV);
            groupBoxNewCountry_MPV.Controls.Add(radioButtonNo_MPV);
            groupBoxNewCountry_MPV.Controls.Add(radioButtonYes_MPV);
            groupBoxNewCountry_MPV.Controls.Add(textBoxAddPopulation_MPV);
            groupBoxNewCountry_MPV.Controls.Add(textBoxAddNational_MPV);
            groupBoxNewCountry_MPV.Controls.Add(textBoxAddCapital_MPV);
            groupBoxNewCountry_MPV.Controls.Add(textBoxAddArea_MPV);
            groupBoxNewCountry_MPV.Controls.Add(textBoxAddCountry_MPV);
            groupBoxNewCountry_MPV.Location = new Point(9, 142);
            groupBoxNewCountry_MPV.Margin = new Padding(3, 4, 3, 4);
            groupBoxNewCountry_MPV.Name = "groupBoxNewCountry_MPV";
            groupBoxNewCountry_MPV.Padding = new Padding(3, 4, 3, 4);
            groupBoxNewCountry_MPV.Size = new Size(628, 265);
            groupBoxNewCountry_MPV.TabIndex = 19;
            groupBoxNewCountry_MPV.TabStop = false;
            groupBoxNewCountry_MPV.Text = "Добавление новых стран:";
            // 
            // groupBoxMain_MPV
            // 
            groupBoxMain_MPV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxMain_MPV.Controls.Add(groupBoxSearch_MPV);
            groupBoxMain_MPV.Controls.Add(groupBoxDelete_MPV);
            groupBoxMain_MPV.Controls.Add(groupBoxNewCountry_MPV);
            groupBoxMain_MPV.Location = new Point(12, 162);
            groupBoxMain_MPV.Margin = new Padding(3, 4, 3, 4);
            groupBoxMain_MPV.Name = "groupBoxMain_MPV";
            groupBoxMain_MPV.Padding = new Padding(3, 4, 3, 4);
            groupBoxMain_MPV.Size = new Size(653, 691);
            groupBoxMain_MPV.TabIndex = 1;
            groupBoxMain_MPV.TabStop = false;
            groupBoxMain_MPV.Text = "Главная";
            // 
            // groupBoxSearch_MPV
            // 
            groupBoxSearch_MPV.Anchor = AnchorStyles.None;
            groupBoxSearch_MPV.Controls.Add(labelColumns_MPV);
            groupBoxSearch_MPV.Controls.Add(labelWhatSearch_MPV);
            groupBoxSearch_MPV.Controls.Add(textBoxColumns_MPV);
            groupBoxSearch_MPV.Controls.Add(textBoxWhatSearch_MPV);
            groupBoxSearch_MPV.Controls.Add(buttonSearch_MPV);
            groupBoxSearch_MPV.Location = new Point(9, 26);
            groupBoxSearch_MPV.Margin = new Padding(3, 4, 3, 4);
            groupBoxSearch_MPV.Name = "groupBoxSearch_MPV";
            groupBoxSearch_MPV.Padding = new Padding(3, 4, 3, 4);
            groupBoxSearch_MPV.Size = new Size(628, 109);
            groupBoxSearch_MPV.TabIndex = 16;
            groupBoxSearch_MPV.TabStop = false;
            groupBoxSearch_MPV.Text = "Поиск:";
            // 
            // labelColumns_MPV
            // 
            labelColumns_MPV.AutoSize = true;
            labelColumns_MPV.Location = new Point(200, 36);
            labelColumns_MPV.Name = "labelColumns_MPV";
            labelColumns_MPV.Size = new Size(120, 20);
            labelColumns_MPV.TabIndex = 24;
            labelColumns_MPV.Text = "Номер столбца:";
            // 
            // labelWhatSearch_MPV
            // 
            labelWhatSearch_MPV.AutoSize = true;
            labelWhatSearch_MPV.Location = new Point(6, 36);
            labelWhatSearch_MPV.Name = "labelWhatSearch_MPV";
            labelWhatSearch_MPV.Size = new Size(86, 20);
            labelWhatSearch_MPV.TabIndex = 23;
            labelWhatSearch_MPV.Text = "Что искать:";
            // 
            // textBoxColumns_MPV
            // 
            textBoxColumns_MPV.Enabled = false;
            textBoxColumns_MPV.Location = new Point(203, 61);
            textBoxColumns_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxColumns_MPV.Name = "textBoxColumns_MPV";
            textBoxColumns_MPV.Size = new Size(106, 27);
            textBoxColumns_MPV.TabIndex = 22;
            // 
            // textBoxWhatSearch_MPV
            // 
            textBoxWhatSearch_MPV.Enabled = false;
            textBoxWhatSearch_MPV.Location = new Point(6, 61);
            textBoxWhatSearch_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxWhatSearch_MPV.Name = "textBoxWhatSearch_MPV";
            textBoxWhatSearch_MPV.Size = new Size(191, 27);
            textBoxWhatSearch_MPV.TabIndex = 21;
            textBoxWhatSearch_MPV.TextChanged += textBoxWhatSearch_MPV_TextChanged;
            // 
            // buttonSearch_MPV
            // 
            buttonSearch_MPV.Enabled = false;
            buttonSearch_MPV.Location = new Point(356, 60);
            buttonSearch_MPV.Margin = new Padding(3, 4, 3, 4);
            buttonSearch_MPV.Name = "buttonSearch_MPV";
            buttonSearch_MPV.Size = new Size(75, 29);
            buttonSearch_MPV.TabIndex = 20;
            buttonSearch_MPV.Text = "Поиск";
            buttonSearch_MPV.UseVisualStyleBackColor = true;
            buttonSearch_MPV.Click += buttonSearch_MPV_Click;
            // 
            // groupBoxDelete_MPV
            // 
            groupBoxDelete_MPV.Anchor = AnchorStyles.None;
            groupBoxDelete_MPV.Controls.Add(labelDelete_MPV);
            groupBoxDelete_MPV.Controls.Add(buttonDelete_MPV);
            groupBoxDelete_MPV.Controls.Add(textBoxDelete_MPV);
            groupBoxDelete_MPV.Location = new Point(9, 415);
            groupBoxDelete_MPV.Margin = new Padding(3, 4, 3, 4);
            groupBoxDelete_MPV.Name = "groupBoxDelete_MPV";
            groupBoxDelete_MPV.Padding = new Padding(3, 4, 3, 4);
            groupBoxDelete_MPV.Size = new Size(628, 124);
            groupBoxDelete_MPV.TabIndex = 20;
            groupBoxDelete_MPV.TabStop = false;
            groupBoxDelete_MPV.Text = "Удаление страны:";
            // 
            // labelDelete_MPV
            // 
            labelDelete_MPV.AutoSize = true;
            labelDelete_MPV.Location = new Point(6, 24);
            labelDelete_MPV.Name = "labelDelete_MPV";
            labelDelete_MPV.Size = new Size(134, 20);
            labelDelete_MPV.TabIndex = 9;
            labelDelete_MPV.Text = "Название страны:";
            // 
            // textBoxDelete_MPV
            // 
            textBoxDelete_MPV.Location = new Point(6, 49);
            textBoxDelete_MPV.Margin = new Padding(3, 4, 3, 4);
            textBoxDelete_MPV.Name = "textBoxDelete_MPV";
            textBoxDelete_MPV.Size = new Size(170, 27);
            textBoxDelete_MPV.TabIndex = 2;
            // 
            // groupBoxSort_MPV
            // 
            groupBoxSort_MPV.Anchor = AnchorStyles.Top;
            groupBoxSort_MPV.Controls.Add(menuStrip1Sort_MPV);
            groupBoxSort_MPV.Location = new Point(882, 162);
            groupBoxSort_MPV.Margin = new Padding(3, 4, 3, 4);
            groupBoxSort_MPV.Name = "groupBoxSort_MPV";
            groupBoxSort_MPV.Padding = new Padding(3, 4, 3, 4);
            groupBoxSort_MPV.Size = new Size(288, 65);
            groupBoxSort_MPV.TabIndex = 20;
            groupBoxSort_MPV.TabStop = false;
            groupBoxSort_MPV.Text = "Сортировка";
            // 
            // menuStrip1Sort_MPV
            // 
            menuStrip1Sort_MPV.ImageScalingSize = new Size(20, 20);
            menuStrip1Sort_MPV.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemSortMax_MPV, ToolStripMenuItemSortMin_MPV });
            menuStrip1Sort_MPV.Location = new Point(3, 24);
            menuStrip1Sort_MPV.Name = "menuStrip1Sort_MPV";
            menuStrip1Sort_MPV.Size = new Size(282, 28);
            menuStrip1Sort_MPV.TabIndex = 0;
            menuStrip1Sort_MPV.Text = "menuStrip1";
            // 
            // ToolStripMenuItemSortMax_MPV
            // 
            ToolStripMenuItemSortMax_MPV.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAreaMax_MPV, ToolStripMenuItemPopulationMax_MPV });
            ToolStripMenuItemSortMax_MPV.Enabled = false;
            ToolStripMenuItemSortMax_MPV.Name = "ToolStripMenuItemSortMax_MPV";
            ToolStripMenuItemSortMax_MPV.Size = new Size(139, 24);
            ToolStripMenuItemSortMax_MPV.Text = "По возрастанию";
            // 
            // ToolStripMenuItemAreaMax_MPV
            // 
            ToolStripMenuItemAreaMax_MPV.Name = "ToolStripMenuItemAreaMax_MPV";
            ToolStripMenuItemAreaMax_MPV.Size = new Size(243, 26);
            ToolStripMenuItemAreaMax_MPV.Text = "Площадь территории";
            ToolStripMenuItemAreaMax_MPV.Click += ToolStripMenuItemAreaMax_MPV_Click;
            // 
            // ToolStripMenuItemPopulationMax_MPV
            // 
            ToolStripMenuItemPopulationMax_MPV.Name = "ToolStripMenuItemPopulationMax_MPV";
            ToolStripMenuItemPopulationMax_MPV.Size = new Size(243, 26);
            ToolStripMenuItemPopulationMax_MPV.Text = "Кол-во населения";
            ToolStripMenuItemPopulationMax_MPV.Click += ToolStripMenuItemPopulationMax_MPV_Click;
            // 
            // ToolStripMenuItemSortMin_MPV
            // 
            ToolStripMenuItemSortMin_MPV.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAreaMin_MPV, ToolStripMenuItemPopulationMin_MPV });
            ToolStripMenuItemSortMin_MPV.Enabled = false;
            ToolStripMenuItemSortMin_MPV.Name = "ToolStripMenuItemSortMin_MPV";
            ToolStripMenuItemSortMin_MPV.Size = new Size(120, 24);
            ToolStripMenuItemSortMin_MPV.Text = "По убыванию";
            // 
            // ToolStripMenuItemAreaMin_MPV
            // 
            ToolStripMenuItemAreaMin_MPV.Name = "ToolStripMenuItemAreaMin_MPV";
            ToolStripMenuItemAreaMin_MPV.Size = new Size(243, 26);
            ToolStripMenuItemAreaMin_MPV.Text = "Площадь территории";
            ToolStripMenuItemAreaMin_MPV.Click += ToolStripMenuItemAreaMin_MPV_Click;
            // 
            // ToolStripMenuItemPopulationMin_MPV
            // 
            ToolStripMenuItemPopulationMin_MPV.Name = "ToolStripMenuItemPopulationMin_MPV";
            ToolStripMenuItemPopulationMin_MPV.Size = new Size(243, 26);
            ToolStripMenuItemPopulationMin_MPV.Text = "Кол-во населения";
            ToolStripMenuItemPopulationMin_MPV.Click += ToolStripMenuItemPopulationMin_MPV_Click;
            // 
            // toolTipInfo_MPV
            // 
            toolTipInfo_MPV.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo_MPV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 862);
            Controls.Add(groupBoxSort_MPV);
            Controls.Add(groupBoxMain_MPV);
            Controls.Add(groupBoxData_MPV);
            Controls.Add(panelTop_MPV);
            MainMenuStrip = menuStrip1Sort_MPV;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "География";
            panelTop_MPV.ResumeLayout(false);
            panelTop_MPV.PerformLayout();
            groupBoxData_MPV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain_MPV).EndInit();
            groupBoxNewCountry_MPV.ResumeLayout(false);
            groupBoxNewCountry_MPV.PerformLayout();
            groupBoxMain_MPV.ResumeLayout(false);
            groupBoxSearch_MPV.ResumeLayout(false);
            groupBoxSearch_MPV.PerformLayout();
            groupBoxDelete_MPV.ResumeLayout(false);
            groupBoxDelete_MPV.PerformLayout();
            groupBoxSort_MPV.ResumeLayout(false);
            groupBoxSort_MPV.PerformLayout();
            menuStrip1Sort_MPV.ResumeLayout(false);
            menuStrip1Sort_MPV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelName_MPV;
        private System.Windows.Forms.Panel panelTop_MPV;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_MPV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_MPV;
        private System.Windows.Forms.Button buttonInfo_MPV;
        private System.Windows.Forms.Button buttonDelete_MPV;
        private System.Windows.Forms.Button buttonAdd_MPV;
        private System.Windows.Forms.Button buttonOpen_MPV;
        private System.Windows.Forms.GroupBox groupBoxData_MPV;
        private System.Windows.Forms.DataGridView dataGridViewMain_MPV;
        private System.Windows.Forms.TextBox textBoxAddCountry_MPV;
        private System.Windows.Forms.TextBox textBoxAddArea_MPV;
        private System.Windows.Forms.TextBox textBoxAddCapital_MPV;
        private System.Windows.Forms.TextBox textBoxAddNational_MPV;
        private System.Windows.Forms.TextBox textBoxAddPopulation_MPV;
        private System.Windows.Forms.RadioButton radioButtonYes_MPV;
        private System.Windows.Forms.RadioButton radioButtonNo_MPV;
        private System.Windows.Forms.Label labelCountry_MPV;
        private System.Windows.Forms.Label labelAddCapital_MPV;
        private System.Windows.Forms.Label labelAddArea_MPV;
        private System.Windows.Forms.Label labelAddDevelop_MPV;
        private System.Windows.Forms.Label labelAddPopulation_MPV;
        private System.Windows.Forms.Label labelAddNational_MPV;
        private System.Windows.Forms.GroupBox groupBoxNewCountry_MPV;
        private System.Windows.Forms.GroupBox groupBoxMain_MPV;
        private System.Windows.Forms.GroupBox groupBoxSearch_MPV;
        private System.Windows.Forms.Label labelColumns_MPV;
        private System.Windows.Forms.Label labelWhatSearch_MPV;
        private System.Windows.Forms.TextBox textBoxColumns_MPV;
        private System.Windows.Forms.TextBox textBoxWhatSearch_MPV;
        private System.Windows.Forms.Button buttonSearch_MPV;
        private System.Windows.Forms.GroupBox groupBoxDelete_MPV;
        private System.Windows.Forms.Label labelDelete_MPV;
        private System.Windows.Forms.TextBox textBoxDelete_MPV;
        private System.Windows.Forms.GroupBox groupBoxSort_MPV;
        private System.Windows.Forms.MenuStrip menuStrip1Sort_MPV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSortMax_MPV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAreaMax_MPV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPopulationMax_MPV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSortMin_MPV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAreaMin_MPV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPopulationMin_MPV;
        private System.Windows.Forms.Button buttonStats_MPV;

        
private System.Windows.Forms.ToolTip toolTipInfo_MPV;
    }
}