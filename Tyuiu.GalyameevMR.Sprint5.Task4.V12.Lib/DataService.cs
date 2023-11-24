using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GalyameevMR.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string z = strX.Replace('.', ',');
            double x = (Convert.ToDouble(z));
            double value = Math.Round(Math.Cos(Math.Pow(x, 3) + x / 2), 3);
            return value;
        }
    }
}
