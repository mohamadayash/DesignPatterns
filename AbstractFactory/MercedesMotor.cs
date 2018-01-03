using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.AbstractFactory
{
    class MercedesMotor:ICarProduct
    {
        public string GetProduct()
        {
            return "Motor 4 cylinders";
        }
    }
}
