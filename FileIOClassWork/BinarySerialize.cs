using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileIOClassWork
{
    public class BinarySerialize
    {
        public static string filePath = @"C:\Users\LENOVO\source\repos\FileIOClassWork\FileIOClassWork\File.txt";

        public static void Serialize()
        {
            Console.WriteLine("Using Binary Serialization");
            Employee emp = new Employee();
            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, emp);
            fileStream.Close();
        }

        public static void Deserialize()
        {
            Console.WriteLine("Using Binary De-Serialization");
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee employee = (Employee)formatter.Deserialize(fileStream);
            Console.WriteLine("Employee Name is "+employee.Name);
            Console.WriteLine("Employee Id is " + employee.id);
            fileStream.Close();
        }

    }

    [Serializable]
    public class Employee
    {
        public string Name
        {
            get;
            set;
        } = "Arjun";

        public int id
        {
            get;
            set;
        } = 103;
    }
}
