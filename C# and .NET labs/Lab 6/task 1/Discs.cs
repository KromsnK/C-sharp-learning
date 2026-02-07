using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    interface IRemoveableDisc
    {
        bool HasDisk { get; }

        void Insert();
        void Reject();
    }
    interface IDisk
    {
        string Read();
        void Write(string text);
    }

    abstract class Disk : IDisk
    {
        protected string memory { get; set;}
        protected int memSize { get; set; }

  


        public Disk() { }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }
        public abstract string GetName();
        public virtual string Read()
        {
            Console.WriteLine("Reading in progress...");
            return memory;
        }
        public virtual void Write(string text)
        {
            Console.WriteLine("Writing...");
            memory = text;
        }

    }
    class HDD : Disk
    {
        public override string GetName()
        {
            string name = "HDD";
            return name;
        }
    }
    class DVD : Disk, IRemoveableDisc
    {
        private bool hasDisk;

        public bool HasDisk { get { return hasDisk; } }
        public override string GetName()
        {
            string name = "DVD";
            return name;
        }
        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine("Inserting...");
        }
        public void Reject() { hasDisk = false; Console.WriteLine("Rejected DVD disc"); }
    }
    class Flash : Disk, IRemoveableDisc
    {
        private bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }

        public override string GetName()
        {
            string name = "Flash";
            return name;
        }
        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine("Flash successfully inserted");
        }
        public void Reject() {
            hasDisk = false; Console.WriteLine("Flash was rejected");
        }
    }
    class CD : Disk, IRemoveableDisc
    {
        private bool hasDisk;
        public bool HasDisk { get { return hasDisk; } }

        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine("CD inserted");
        }
        public void Reject() {
            hasDisk = false; Console.WriteLine("CD was rejected");
        }
        public override string GetName()
        {
            string name = "CD";
            return name;
        }
    }
}
