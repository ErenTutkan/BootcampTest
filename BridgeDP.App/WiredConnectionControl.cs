using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.App
{
    internal class WiredConnectionControl : AbstractConnectionControl
    {
        public WiredConnectionControl(IPrinter printer) : base(printer)
        {
        }

        public override void SetScan()
        {
            _printer.Scan();
            Console.WriteLine("Kablolu Bağlantıdan yollandı.");
        }
    }
}
