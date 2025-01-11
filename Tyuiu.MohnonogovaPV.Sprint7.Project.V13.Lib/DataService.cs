
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);
            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }

        public string[,] SortMin(string[,] matrix, int NumberColumn) // по возрастанию
        {
            double[] Entrance = new double[matrix.GetLength(0) - 1];
            for (int i = 0; i < Entrance.Length; i++)
            {
                if (double.TryParse(matrix[i + 1, NumberColumn], out Entrance[i]))
                {
                    continue;
                }
                else
                {
                    throw new FormatException($"The value '{matrix[i + 1, NumberColumn]}' in row {i + 1}, column {NumberColumn} is not a valid number.");
                }
            }

            Array.Sort(Entrance);

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToDouble(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        break;
                    }
                }
            }
            return SortMatrix;
        }

        public string[,] SortMax(string[,] matrix, int NumberColumn) // по убыванию
        {
            double[] Entrance = new double[matrix.GetLength(0) - 1];
            for (int i = 0; i < Entrance.Length; i++)
            {
                if (double.TryParse(matrix[i + 1, NumberColumn], out Entrance[i]))
                {
                    continue;
                }
                else
                {
                    throw new FormatException($"The value '{matrix[i + 1, NumberColumn]}' in row {i + 1}, column {NumberColumn} is not a valid number.");
                }
            }

            Array.Sort(Entrance);
            Array.Reverse(Entrance);

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToDouble(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        break;
                    }
                }
            }
            return SortMatrix;
        }

        
public string[,] Search(string[,] DataTable, string Brand, int Columns)
        {
            int flag = 0;
            for (int i = 1; i < DataTable.GetLength(0); i++) // Начинаем с 1, чтобы пропустить заголовок
            {
                if (DataTable[i, Columns].Equals(Brand, StringComparison.OrdinalIgnoreCase))
                {
                    flag++;
                }
            }

            string[,] res = new string[flag, DataTable.GetLength(1)];
            int f = 0;

            for (int i = 1; i < DataTable.GetLength(0); i++) // Начинаем с 1, чтобы пропустить заголовок
            {
                if (DataTable[i, Columns].Equals(Brand, StringComparison.OrdinalIgnoreCase))
                {
                    for (int r = 0; r < res.GetLength(1); r++)
                    {
                        res[f, r] = DataTable[i, r];
                    }
                    f++;
                }
            }
            return res;
        }

        public bool CountryExist(string[,] DataTable, string Country)
        {
            bool b = false;
            for (int i = 1; i < DataTable.GetLength(0); i++) // Начинаем с 1, чтобы пропустить заголовок
            {
                if (Country.Equals(DataTable[i, 1], StringComparison.OrdinalIgnoreCase))
                    b = true;
            }
            return b;
        }

        public string[] ArrayStrWordsElements(string[,] DataTable, int NumColumns)
        {
            List<string> uniqueElements = new List<string>();
            for (int i = 1; i < DataTable.GetLength(0); i++) // Начинаем с 1, чтобы пропустить заголовок
            {
                if (!uniqueElements.Contains(DataTable[i, NumColumns]))
                {
                    uniqueElements.Add(DataTable[i, NumColumns]);
                }
            }
            return uniqueElements.ToArray();
        }

        public int[] ArraySumWords(string[,] DataTable, string[] Entrance, int NumColumns)
        {
            int[] res = new int[Entrance.Length];
            for (int i = 0; i < Entrance.Length; i++)
            {
                for (int j = 1; j < DataTable.GetLength(0); j++) // Начинаем с 1, чтобы пропустить заголовок
                {
                    if (Entrance[i].Equals(DataTable[j, NumColumns], StringComparison.OrdinalIgnoreCase))
                        res[i] += 1;
                }
            }
            return res;
        }

        public double Average(string[,] DataTable, int NumColumns)
        {
            double average = 0;
            double sum = 0;
            int count = 0;
            for (int r = 1; r < DataTable.GetLength(0); r++) // Начинаем с 1, чтобы пропустить заголовок
            {
                if (double.TryParse(DataTable[r, NumColumns], out double value))
                {
                    sum += value;
                    count++;
                }
            }
            if (count > 0)
            {
                average = sum / count;
            }
            return Math.Round(average, 1);
        }
    }
}