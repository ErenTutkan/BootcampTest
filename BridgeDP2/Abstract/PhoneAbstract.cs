using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Abstract
{
    internal abstract class PhoneAbstract
    {
        IBattery _battery;
        IProcessor _processor;

        protected PhoneAbstract(IBattery battery, IProcessor processor)
        {
            _battery = battery;
            _processor = processor;
        }
        public void StartProcessor()
        {
            _processor.Start();
        }
        public void Charge()
        {
            _battery.Charge();
        }
        public abstract void StartPhone();
    }
}
