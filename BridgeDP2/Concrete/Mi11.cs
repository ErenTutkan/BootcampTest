using BridgeDP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Concrete
{
    internal class Mi11 : PhoneAbstract
    {
        public Mi11(IBattery battery, IProcessor processor) : base(battery, processor)
        {
        }

        public override void StartPhone()
        {
            base.Charge();
            base.StartProcessor();
            Console.WriteLine("Mi 11 Başlatıldı.");
        }
    }
}
