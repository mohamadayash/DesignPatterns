﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.AbstractFactory
{
    public class MercedesDoor:ICarProduct
    {
        public string GetProduct()
        {
            return "Two sport doors";
        }
    }
}
