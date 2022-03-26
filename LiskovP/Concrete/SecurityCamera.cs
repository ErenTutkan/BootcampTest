using LiskovP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovP.Concrete
{
    internal class SecurityCamera:BaseCamera
    {
        public override void StartCapture()
        {
            Console.WriteLine("Güvenlik Kamerası Başlatıldı");
        }
        public override void StopCapture()
        {
            Console.WriteLine("Güvenlik Kamerası Kapatıldı");
        }
    }
}
