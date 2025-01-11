using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MohnonogovaPV.Sprint7.Project.V13.Lib;

namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13
{
    public partial class FormStats : Form
    {
        DataService ds = new DataService();
        public static string path = @"C:\Users\User\source\repos\Tyuiu.MohnonogovaPV.Sprint7\Tyuiu.MohnonogovaPV.Project.V13\bin\Debug\net8.0-windows\countries.csv";

        public FormStats()
        {
            InitializeComponent();
        }

        private void buttonDevelop_MPV_Click(object sender, EventArgs e)
        {
            chartStats_MPV.Series[0].Points.Clear();

            this.chartStats_MPV.ChartAreas[0].AxisX.Title = "Является ли страна развитой";
            this.chartStats_MPV.ChartAreas[0].AxisY.Title = "Количество стран";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 4);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 4);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartStats_MPV.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }
        }

        private void buttonNational_MPV_Click(object sender, EventArgs e)
        {
            chartStats_MPV.Series[0].Points.Clear();

            this.chartStats_MPV.ChartAreas[0].AxisX.Title = "Преобладающая национальность";
            this.chartStats_MPV.ChartAreas[0].AxisY.Title = "Количество стран";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 6);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 6);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartStats_MPV.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }
        }

        private void buttonViewStats_MPV_Click(object sender, EventArgs e)
        {
            string[,] DataTable = ds.GetMatrix(path);
            double AverageArea = ds.Average(DataTable, 3);
            double AveragePopulation = ds.Average(DataTable, 5);

            textBoxAverageArea_MPV.Text = Convert.ToString(AverageArea);
            textBoxAveragePopulation_MPV.Text = Convert.ToString(AveragePopulation);
        }
    }
}