﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint5.Task0.V27.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        { 
            DataService DataService = new DataService(); 
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string res = DataService.SaveToFileTextData(3);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
