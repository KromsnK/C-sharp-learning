using System;
using System.Collections.Generic;
using System.Linq;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HDD hdd = new HDD();
            hdd.Write("Hello world!");
            Console.WriteLine(hdd.Read());
            DVD dvd = new DVD();
            dvd.Insert();
            dvd.Write("Hello world!");
            Console.WriteLine(dvd.Read());
            dvd.Reject();
        }
    }
}

