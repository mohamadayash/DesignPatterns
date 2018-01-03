using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.AbstractFactory
{
    public class MercedesWheel:ICarProduct
    {

        public string GetProduct()
        {
            return "4 big wheels";
        }
    }
}
