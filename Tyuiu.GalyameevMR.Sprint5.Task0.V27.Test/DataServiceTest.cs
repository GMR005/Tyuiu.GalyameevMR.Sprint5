using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalyameevMR.Sprint5.Task0.V27.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile() 
        {
            string path = @"C:\visual studio\Tyuiu.GalyameevMR.Sprint5\Tyuiu.GalyameevMR.Sprint5.Task0.V27\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
