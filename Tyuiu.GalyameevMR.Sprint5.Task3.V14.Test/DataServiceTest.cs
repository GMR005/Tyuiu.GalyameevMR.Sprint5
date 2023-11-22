using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalyameevMR.Sprint5.Task3.V14.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\visual studio\Tyuiu.GalyameevMR.Sprint5\Tyuiu.GalyameevMR.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(path); 
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
