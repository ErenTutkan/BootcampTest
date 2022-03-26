using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovP.Abstract
{
    internal abstract class BaseCamera
    {
        public virtual void StartCapture()
        {
            Console.WriteLine("Kamera Açıldı.");
        }
        public virtual void StopCapture()
        {
            Console.WriteLine("Kamera Kapandı.");
        }
    }
}
