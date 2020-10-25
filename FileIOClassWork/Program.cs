using System;
using System.IO;

namespace FileIOClassWork
{
    class Program
    {
        public static string filePath= @"C:\Users\LENOVO\source\repos\FileIOClassWork\FileIOClassWork\File.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FileIO program!");
            if (FileExists())
            {
                Console.WriteLine("Writing data into a file");
                FileWrite();
                Console.WriteLine("Reading data from file");
                FileRead();
                Console.WriteLine();
                Console.WriteLine("Using StreamReader and StreamWriter.");
                Stream.WriteUsingStreamWriter();
                Stream.ReadUsingStreamReader();
                Console.WriteLine();
                BinarySerialize.Serialize();
                BinarySerialize.Deserialize();
            }
        }

        public static bool FileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists");
                return true;
            }
            else
            {
                Console.WriteLine("File Doesn't Exists");
                return false;
            }
        }

        public static void FileWrite()
        {
            string content = "Ny Name is Akash."+"\n"+"I am an Engineer."+"\n";
            File.WriteAllText(filePath, content);
        }

        public static void FileRead()
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
    }
}
