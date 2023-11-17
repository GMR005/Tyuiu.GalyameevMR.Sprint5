using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalyameevMR.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = (3 * i - 1.5)/(Math.Sin(i) - 3 + i);
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
