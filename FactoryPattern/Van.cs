using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    public class Van : IVechile
    {

        public string Info()
        {
            return "this is a van";
        }

        public string Name
        {
            get
            {
                return "Honda";
            }
        }

        public string Color
        {
            get
            {
                return "Red";
            }
        }

        public int Wheels
        {
            get
            {
                return 4;
            }
        }

        public int Cylinders
        {
            get
            {
                return 6;
            }
        }
    }
}
