using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SERIALIZATION_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //serialization

            //string path = @"D:\Aayush new\sample.png";
            //Employee emp = new Employee(123,"Aayush");
            //FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(stream, emp);
            //stream.Close();
            //Console.WriteLine("FIle created sucessfully..");
            //Console.ReadLine();
            //De-serialization
            string path = @"D:\Aayush new\sample.txt";
            FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee)bf.Deserialize(stream);
            Console.WriteLine("Employee Id:"+emp.Id);
            Console.WriteLine("Employee Name:" + emp.Name);
            stream.Close();
            Console.ReadLine();


        }
    }
}
