using FacadeDP.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.App.Concrete
{
    internal class AirCooler : ICooler
    {
        public void Start()
        {
            Console.WriteLine("Soğutucu Başlatıldı");
        }

        public void Stop()
        {
            Console.WriteLine("Soğutucu Durduruldu");
        }
    }
}
