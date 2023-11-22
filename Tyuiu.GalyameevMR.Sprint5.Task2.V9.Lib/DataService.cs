using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalyameevMR.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            if (fileExists)
            {
                File.Delete(path);
            };
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;
        }
    }
}
