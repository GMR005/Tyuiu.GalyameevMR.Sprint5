using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalyameevMR.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string z = File.ReadAllText(path);
            int count = 0;
            string[] words = z.Split(' ');
            foreach (string word in words)
                if (word.Length == 7)
                {
                    count++;
                }
            return count;
        }  
    }
}
