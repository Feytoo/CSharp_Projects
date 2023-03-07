using System;
using System.IO;

namespace ATM
{
    internal class Logger : ILogger
    {
        
        public void EndOfTheDayReadFile()
        {
            string filePath = @"C:\Users\sabom\OneDrive\Masaüstü" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string log = sr.ReadLine();

            while (log != null)
            {
                Console.WriteLine(log);
                log = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

        public void WriteFile(string message)
        {
            string filePath = @"C:\Users\sabom\OneDrive\Masaüstü" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(message);

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}