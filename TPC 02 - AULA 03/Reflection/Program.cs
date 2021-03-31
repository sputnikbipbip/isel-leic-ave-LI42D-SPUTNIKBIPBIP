using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom("RestSharp.dll");
            Type[] types = assembly.GetTypes();
            foreach(Type type in types)
            {
                Console.WriteLine("Type -> " + type.Name);
                MethodInfo[] methods = type.GetMethods();
                if(methods[0] != null)
                {
                    foreach(MethodInfo method in methods)
                    {
                        Console.WriteLine("\t Method -> " + method.Name);
                    }
                }
            }
        }
    }
}
