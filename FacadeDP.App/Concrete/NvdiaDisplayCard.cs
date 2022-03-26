using FacadeDP.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.App.Concrete
{
    internal class NvdiaDisplayCard : IDisplayCard
    {
        public void Start()
        {
            Console.WriteLine("Nvdia Ekran Kartı Başlatıldı");
        }

        public void Stop()
        {
            Console.WriteLine("Nvdia Ekran Kartı Durduruldu.");
        }
    }
}
