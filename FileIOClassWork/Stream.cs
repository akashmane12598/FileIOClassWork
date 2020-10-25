using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOClassWork
{
    public class Stream
    {
        public static string filePath = @"C:\Users\LENOVO\source\repos\FileIOClassWork\FileIOClassWork\File.txt";

        public static void WriteUsingStreamWriter()
        {
            using (StreamWriter stw = File.AppendText(filePath))
            {
                string content = "Written using StreamWriter";
                stw.WriteLine(content);
            }
        }

        public static void ReadUsingStreamReader()
        {
            using (StreamReader str = File.OpenText(filePath))
            {
                string s = "";
                while ((s = str.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
