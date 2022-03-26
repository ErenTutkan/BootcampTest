using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityP
{
    internal class ProductManager
    {
        private ProductValidation _productValiton=new ProductValidation();
        public void Add(string productname)
        {
            if (!_productValiton.Validation())
                Console.WriteLine("Eklenemedi");
            else
            Console.WriteLine("{0} Eklendi",productname);
        }
    }
}
