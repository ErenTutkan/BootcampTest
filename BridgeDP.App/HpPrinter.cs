using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.App
{
    internal class HpPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("HP Printerdan Basıldı");
        }

        public void Scan()
        {
            Console.WriteLine(" Hp Printerdan Tarandı.");
        }
    }
}
