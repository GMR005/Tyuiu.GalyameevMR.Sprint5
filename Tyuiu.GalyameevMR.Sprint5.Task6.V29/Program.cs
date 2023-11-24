using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GalyameevMR.Sprint5.Task6.V29.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task6.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask6V29.txt";
            string res = File.ReadAllText(path);
            Console.WriteLine(res); Console.WriteLine("Файл находится тут: " + path);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double z = ds.LoadFromDataFile(path);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
