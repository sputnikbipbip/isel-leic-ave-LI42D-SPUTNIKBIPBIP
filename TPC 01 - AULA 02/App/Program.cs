using System;
using PointLib;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(3, 4);
            Console.WriteLine("Module = " + p.getModule());
        }
    }
}
