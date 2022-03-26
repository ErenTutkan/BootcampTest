using InterfaceSegregation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Concrete
{
    internal class Car : IVehicle
    {
        public void Backward()
        {
            Console.WriteLine("Geri");
        }

        public void Forward()
        {
            Console.WriteLine("İleri");
        }

        public void Left()
        {
            Console.WriteLine("Sola");
        }

        public void Right()
        {
            Console.WriteLine("Sağ");
        }
    }
}
