using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            //string path = @"C:\Users\akshata\source\fieio\MyDirectory\MyAnotherDirectory\NewFile.txt";
            //employee emp = new employee(101,"akshata",20000);
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter bf=new BinaryFormatter();
            //bf.Serialize(fs,emp);
            //fs.Close();


 
            string path = @"C:\Users\akshata\source\fieio\MyDirectory\MyAnotherDirectory\NewFile.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            employee emp = (employee)bf.Deserialize(fs);
            Console.WriteLine("employee id : "+emp.id);
            Console.WriteLine("employee Name : " + emp.name);
            Console.WriteLine("employee basic salary : "+emp.basicsalary);

            fs.Close();
        }
    }
}