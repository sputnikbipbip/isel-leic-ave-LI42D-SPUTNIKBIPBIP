using System;
using System.Reflection;
using Logger;

namespace App
{
    class Program
    {

        static void Main(string[] args)
        {
            Point p = new Point(7, 9);
            Student s1 = new Student(154134, "Ze Manel", 5243, "ze");
            Student s2 = new Student(154134, "Xico", 1234, "xico");
            Account a = new Account(1300);
            // Console.WriteLine(p);
            // Console.WriteLine(s1);
            // Console.WriteLine(a);        
            Log l = new Log();
            l.Info(p);
            l.Info(s1);
            l.Info(s2);
            l.Info(a);

            /*
            Type t = p.GetType();
            ToLogAttribute[] MyAttributes =
                (ToLogAttribute[])Attribute.GetCustomAttributes(t, typeof(ToLogAttribute));

            if (MyAttributes.Length == 0)
            {
                Console.WriteLine("label not found");
            }
            else
            {
                for (int i = 0; i < MyAttributes.Length; i++)
                {
                    Console.WriteLine("My attribute name -> " + MyAttributes[i].label);
                }
            }*/

            /*
            var properties = typeof(Student).GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine($"Prop name: {property.Name}");
                if (Attribute.IsDefined(property, typeof(ToLogAttribute)))
                {
                    Console.WriteLine(property.
                        GetCustomAttribute<ToLogAttribute>().Title);
                }
            }
            */
            var methods = typeof(Point).GetMethods();
            var fields = typeof(Point).GetFields();

            Console.WriteLine("\n");
            foreach (var method in methods)
            {
                Console.WriteLine($"Method name: {method.Name}");
                if (Attribute.IsDefined(method, typeof(ToLogAttribute)))
                {
                    Console.WriteLine("\t" + 
                        method.GetCustomAttribute<ToLogAttribute>().Title);
                }
            }

            Console.WriteLine("\n");
            foreach (var field in fields)
            {
                Console.WriteLine($"Field name: {field.Name}");
                if (Attribute.IsDefined(field, typeof(ToLogAttribute)))
                {
                    Console.WriteLine("\t" + 
                        field.GetCustomAttribute<ToLogAttribute>().Title);
                }
            }

        }
    }
}
