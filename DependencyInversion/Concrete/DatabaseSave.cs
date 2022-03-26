using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
    internal class DatabaseSave : ISave
    {
        public void Save()
        {
            Console.WriteLine("Veritabanına Kaydedildi");
        }
    }
}
