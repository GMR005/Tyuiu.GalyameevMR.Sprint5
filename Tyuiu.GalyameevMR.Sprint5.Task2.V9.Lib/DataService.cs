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
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); i++)
                {
                    if (j != matrix.GetLength(1) - 1)
                    {
                        res += matrix[i, j] + ";";
                    }
                    else
                    {
                        res += matrix[i, j];
                    }
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(path, res + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, res);
                }
            }
            return path;
        }
    }
}
