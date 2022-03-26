using LiskovP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovP.Concrete
{
    internal class WebCamera : BaseCamera, IMicrophone
    {
        public void StartMicrophone()
        {
            Console.WriteLine("Mikrofon Başlatıldı.");
        }

        public void StopMicrophone()
        {
            Console.WriteLine("Mikrofon Kapatıldı.");
        }
    }
}
