using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.App
{
    internal class CanonPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine(" Canon Printerdan Basıldı");
        }

        public void Scan()
        {
            Console.WriteLine("Canon Printerdan Tarandı.");
        }
    }
}
