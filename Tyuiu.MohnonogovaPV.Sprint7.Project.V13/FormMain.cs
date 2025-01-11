using Tyuiu.MohnonogovaPV.Project.V13;
using Tyuiu.MohnonogovaPV.Sprint7.Project.V13.Lib;
using System;
using System.IO;

namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridViewMain_MPV.RowCount = 100;
            dataGridViewMain_MPV.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewMain_MPV.Columns[i].Width = 150;
            }
        }
        DataService ds = new DataService();
        public static string path = @"C:\Users\Полина\source\repos\Tyuiu.MohnonogovaPV.Sprint7\Tyuiu.MohnonogovaPV.Sprint7.Project.V13\bin\Debug\net8.0-windows\countries.csv";

        private void buttonStats_MPV_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            formStats.Show();
        }

        private void buttonOpen_MPV_Click(object sender, EventArgs e)
        {
            openFileDialogMain_MPV.ShowDialog();
            string FileName = openFileDialogMain_MPV.FileName;

            // Блокировка файла
            using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                string[,] DataMatrix = ds.GetMatrix(FileName);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewMain_MPV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
                ToolStripMenuItemSortMax_MPV.Enabled = true;
                ToolStripMenuItemSortMin_MPV.Enabled = true;
                buttonSearch_MPV.Enabled = true;
                textBoxWhatSearch_MPV.Enabled = true;
                textBoxColumns_MPV.Enabled = true;
            }
        }

        private void buttonReturn_MPV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_MPV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
        }

        private void ToolStripMenuItemAreaMax_MPV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_MPV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_MPV.Enabled = true;
        }

        private void ToolStripMenuItemAreaMin_MPV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_MPV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_MPV.Enabled = true;
        }

        private void ToolStripMenuItemPopulationMax_MPV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 5);


            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_MPV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_MPV.Enabled = true;
        }

        private void ToolStripMenuItemPopulationMin_MPV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_MPV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_MPV.Enabled = true;
        }

        private void buttonSearch_MPV_Click(object sender, EventArgs e)
        {
            if ((textBoxColumns_MPV.Text == ""))
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[,] DataMatrix = ds.GetMatrix(path);

                if ((Convert.ToInt32(textBoxColumns_MPV.Text) < 1))
                {
                    MessageBox.Show("Нет такого столбца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxWhatSearch_MPV.Text = "";
                    textBoxColumns_MPV.Text = "";
                }
                else
                {
                    string[,] str = ds.Search(DataMatrix, textBoxWhatSearch_MPV.Text, Convert.ToInt32(textBoxColumns_MPV.Text) - 1);
                    try
                    {
                        if (str.Length == 0)
                            MessageBox.Show("Не нашлось совпадений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            for (int r = 1; r < DataMatrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < DataMatrix.GetLength(1); c++)
                                {
                                    dataGridViewMain_MPV.Rows[r].Cells[c].Value = "";
                                }
                            }
                            for (int i = 0; i < DataMatrix.GetLength(1); i++)
                            {
                                dataGridViewMain_MPV.Rows[0].Cells[i].Value = DataMatrix[0, i];
                            }
                            for (int r = 0; r < str.GetLength(0); r++)
                            {
                                for (int c = 0; c < str.GetLength(1); c++)
                                {
                                    dataGridViewMain_MPV.Rows[r + 1].Cells[c].Value = str[r, c];
                                }
                            }

                            buttonReturn_MPV.Enabled = true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не нашлось совпадений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxWhatSearch_MPV.Text = "";
                        textBoxColumns_MPV.Text = "";
                    }
                }
            }
        }

        private void buttonAdd_MPV_Click(object sender, EventArgs e)
        {
            if ((textBoxAddPopulation_MPV.Text == "") || ((radioButtonNo_MPV.Checked == false) && (radioButtonYes_MPV.Checked == false)))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";


                string[,] DataTable = ds.GetMatrix(path);

                bool CountryBusy = ds.CountryExist(DataTable, textBoxAddCountry_MPV.Text);

                if (CountryBusy)
                    MessageBox.Show("Данная Страна уже есть в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    str = $"{DataTable.GetLength(0)};{textBoxAddCountry_MPV.Text};{textBoxAddCapital_MPV.Text};{textBoxAddArea_MPV.Text};{(radioButtonYes_MPV.Checked ? "да" : "нет")};{textBoxAddPopulation_MPV.Text};{textBoxAddNational_MPV.Text}";

                    File.AppendAllText(path, str + "\n");

                    textBoxAddArea_MPV.Text = "";
                    textBoxAddCapital_MPV.Text = "";
                    textBoxAddCountry_MPV.Text = "";
                    textBoxAddNational_MPV.Text = "";
                    textBoxAddPopulation_MPV.Text = "";
                    radioButtonNo_MPV.Checked = false;
                    radioButtonYes_MPV.Checked = false;

                    string[,] DataMatrixUpdated = ds.GetMatrix(path);

                    int rows = DataMatrixUpdated.GetLength(0);
                    int columns = DataMatrixUpdated.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_MPV.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_MPV.Rows[r].Cells[c].Value = DataMatrixUpdated[r, c];
                        }
                    }

                    MessageBox.Show("Страна занесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDelete_MPV_Click(object sender, EventArgs e)
        {
            if (textBoxDelete_MPV.Text == "")
            {
                MessageBox.Show("Поле пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[,] DataTable = ds.GetMatrix(path);
                bool CountryBusy = ds.CountryExist(DataTable, textBoxDelete_MPV.Text);

                if (CountryBusy == false)
                    MessageBox.Show("Такой страны нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    List<string[]> newData = new List<string[]>();
                    for (int i = 1; i < DataTable.GetLength(0); i++)
                    {
                        if (DataTable[i, 1] != textBoxDelete_MPV.Text)
                        {
                            string[] row = new string[DataTable.GetLength(1)];
                            for (int j = 0; j < DataTable.GetLength(1); j++)
                            {
                                row[j] = DataTable[i, j];
                            }
                            newData.Add(row);
                        }
                    }

                    string[] newDataArray = new string[newData.Count + 1];
                    newDataArray[0] = string.Join(";", DataTable[0,0]);
                    for (int i = 0; i < newData.Count; i++)
                    {
                        newDataArray[i + 1] = string.Join(";", newData[i]);
                    }

                    File.WriteAllLines(path, newDataArray);

                    string[,] DataMatrixUpdated = ds.GetMatrix(path);

                    int rows = DataMatrixUpdated.GetLength(0);
                    int columns = DataMatrixUpdated.GetLength(1);


                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_MPV.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_MPV.Rows[r].Cells[c].Value = DataMatrixUpdated[r, c];
                        }
                    }
                    MessageBox.Show("Страна удалена из базы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxDelete_MPV.Text = "";
        }

        private void buttonHelp_MPV_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.Show();
        }

        private void buttonInfo_MPV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void textBoxWhatSearch_MPV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}