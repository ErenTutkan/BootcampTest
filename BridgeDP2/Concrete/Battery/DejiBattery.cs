using BridgeDP2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP2.Concrete.Battery
{
    internal class DejiBattery : IBattery
    {
        public void Charge()
        {
            Console.WriteLine("Deji Batarya Şarj Edildi.");
        }
    }
}
