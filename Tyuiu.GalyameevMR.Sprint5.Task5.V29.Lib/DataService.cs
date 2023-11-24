using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalyameevMR.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                double MinRes = int.MaxValue;
                double Min = int.MaxValue;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double temp = Convert.ToDouble(line);
                    if ((Convert.ToDouble(line) < Min) && (10 <= temp && temp < 100))
                    {
                        Min = Convert.ToDouble(line);
                        MinRes = double.Parse(line);
                    }
                }
                return Math.Round(MinRes, 3);
            }
        }
        
    }
}
