using System.Reflection;

namespace reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dllfile = @"C:\Users\akshata\source\repos\UserData\bin\Debug\net6.0\UserData.dll";

            var assembly = Assembly.LoadFile(dllfile);
            var type = assembly.GetType("UserData.Userdata");
            var obj=Activator.CreateInstance(type);
            var method = type.GetMethod("displayname");
            var result=method.Invoke(obj, new object[] { "AKSHATA"});
            Console.WriteLine(result);
            Console.Read();

        }
    }
}