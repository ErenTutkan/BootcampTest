using BridgeDP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Concrete.Process
{
    internal class AppleA14Processor : IProcessor
    {
        public void Start()
        {
            Console.WriteLine("Apple A14 İşlemci Çalıştırıldı.");
        }
    }
}
