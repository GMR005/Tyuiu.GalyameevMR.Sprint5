using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint5.Task5.V29.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask5V29.txt";
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine( res);
            Console.ReadKey();
        }
    }
}
