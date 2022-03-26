using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
    internal class MongoDbSave : ISave
    {
        public void Save()
        {
            Console.WriteLine("MongoDbye Kaydedildi");
        }
    }
}
