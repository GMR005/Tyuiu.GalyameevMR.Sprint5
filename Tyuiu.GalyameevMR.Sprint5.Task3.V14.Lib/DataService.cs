using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalyameevMR.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    { 
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path); 
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            };
            double value = 4 * Math.Pow(x, 3) / (Math.Pow(x, 3) - 1);
            value = Math.Round(value, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8)) 
            {
                writer.Write(BitConverter.GetBytes(value));
            }
            return path;

        }
    }
}
