using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP.App
{
    internal abstract class AbstractConnectionControl
    {
       private readonly IPrinter _printer;

        public AbstractConnectionControl(IPrinter printer)
        {
            _printer = printer;
        }
        public void Scan()
        {
            _printer.Scan();
        }
        public void Print()
        {
            _printer.Print();
        }
        public abstract void SetScan();
    }
}
