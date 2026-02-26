using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Comp
    {
        private int countDisk;
        private int countPrintDevice;
        private Disk[] disks;
        private IPrintInformation[] printDevice;

        void AddDevice(int index,IPrintInformation si)
        {
            IPrintInformation si2 = si as IPrintInformation;
            countPrintDevice++;
        }
        void AddDisk(int index, Disk disk)
        {
            disks[index] = disk;
            countDisk++;
        }
        bool CheckDisk(string device )
        {
           for (int i = 0; i < countDisk; i++)
            {
                if (disks[i].GetName() == device)
                {
                    return true;
                }
            }
            return false;

        }
        public Comp(int d,int pd)
        {
            disks = new Disk[d];
            printDevice = new IPrintInformation[pd];
            countDisk = 0;
            countPrintDevice = 0;
        }
        void InsertReject(string device, bool b)
        {

        }
     

    }
}
