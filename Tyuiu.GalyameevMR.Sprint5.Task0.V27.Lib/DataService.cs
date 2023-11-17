using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalyameevMR.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27 
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Pow((x - 1), (3 * x + 1));
            z = Math.Round(z, 2);
            File.WriteAllText(path, Convert.ToString(z));
            return path;


        }
    }
}
