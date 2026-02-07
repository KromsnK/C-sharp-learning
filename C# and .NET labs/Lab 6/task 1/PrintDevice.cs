using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    interface IPrintInformation
    {
        string GetName();
        void Print(string str);
    }
    class Printer : IPrintInformation
    {
        string Name = "Printer";

        public string GetName()
        {
            return Name;
        }
        public void Print(string str)
        {
            Console.WriteLine("Printing info on printer");
        }
    }
    class Monitor : IPrintInformation
    {
        string Name = "Monitor";
        public string GetName()
        {
            return Name;
        }
        public void Print(string str)
        {
            Console.WriteLine("Printing info on monitor....");
        }
    }
}
