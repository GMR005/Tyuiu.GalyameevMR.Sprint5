using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint5.Task4.V12.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            string path = $@"C:\DataSprint5\Sprint5Task4\InPutDataFileTask4V12.txt";
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double value = DataService.LoadFromDataFile(path);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
