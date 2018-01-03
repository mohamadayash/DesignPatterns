using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes
{
    public interface IVechile
    {
        String Name {  get; }

        String Color {  get; }

        int Wheels {  get; }

        int Cylinders { get; }

        String Info();
    }
}
