using BridgeDP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Concrete
{
    internal class OnePlus9 : PhoneAbstract
    {
        public OnePlus9(IBattery battery, IProcessor processor) : base(battery, processor)
        {
        }

        public override void StartPhone()
        {
            base.Charge();
            base.StartProcessor();
            Console.WriteLine("One Plus 9 Başlatıldı");
        }
    }
}
