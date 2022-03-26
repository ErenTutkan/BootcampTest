using DependencyInversion.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Concrete
{
    internal class SaveProduct
    {
        ISave _save;

        public SaveProduct(ISave save)
        {
            _save = save;
        }
        public void Save()
        {
            _save.Save();
        }
    }
}
