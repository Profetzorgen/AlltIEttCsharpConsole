using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamlingsBlahaAllaÖvningar
{
    internal class Cirkel
    {
        public double Radie;
        public Cirkel(double r)
        {
            Radie = r;
        }
        public double Area()
        {
           return Radie*Radie*Math.PI;
        }
        public double Omkrets()
        {
            return Radie+Radie*Math.PI;
        }
        public override string ToString()
        {
            return "Arean på Cirkeln är: " + Area().ToString() +
                " och omkretsen är: " + Omkrets().ToString();
        }
    }
}
