using BridgeDP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Concrete.Process
{
    internal class SnapDragon888Processor:IProcessor
    {
        public void Start()
        {
            Console.WriteLine("SnapDragon 888 İşlemci Çalıştırıldı.");
        }
    }
}
