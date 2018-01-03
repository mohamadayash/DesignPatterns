﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    public class VechileFactory<IVechile>
    {

        public VechileFactory()
        {

        }

        public static IVechile CreateVechile()
        {
            return Activator.CreateInstance<IVechile>();
        }
    }
}
