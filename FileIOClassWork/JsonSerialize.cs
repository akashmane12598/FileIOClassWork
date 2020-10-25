using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace FileIOClassWork
{
    public class JsonSerialize
    {
        public static void Serialize()
        {
            Console.WriteLine("Using Json Serialization");
            EmployeeJson employeeJson = new EmployeeJson()
            {
                Name = "Sachin",
                Id = 105
            };

            string json = JsonConvert.SerializeObject(employeeJson);
            Console.WriteLine(json);
        }

        public static void DeSerialize()
        {
            Console.WriteLine("Using Json De-Serialization");
            string json = @"(
                    'Name': 'Tarun',
                    'Id': '111'
            )";
            EmployeeJson employee = JsonConvert.DeserializeObject<EmployeeJson>(json);
            Console.WriteLine(employee.Name+": "+employee.Id);
        }

    }

    [DataContract]
    public class EmployeeJson
    {
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        [DataMember]
        public int Id
        {
            get;
            set;
        }
    }


}
