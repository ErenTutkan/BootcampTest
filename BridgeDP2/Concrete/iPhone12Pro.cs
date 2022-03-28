using BridgeDP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Concrete
{
    internal class iPhone12Pro : PhoneAbstract
    {
        public iPhone12Pro(IBattery battery, IProcessor processor) : base(battery, processor)
        {
        }

        public override void StartPhone()
        {
            base.Charge();
            base.StartProcessor();
            Console.WriteLine("IPhone 12 Pro Modeli Başlatıldı.");
        }
    }
}
