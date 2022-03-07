using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingsBlahaAllaÖvningar
{
    internal class Kvadrat
    {
        public int Sida;
        public Kvadrat(int s)
        {
            Sida = s;
        }
        public int Area()
        {
            return Sida * Sida;
        }
        public int Omkrets()
        {
            return 4 * Sida;
        }
        public override string ToString()
        {
            return "Arean på Kvadraten är: " + Area().ToString() +
                " och omkretsen är: " + Omkrets().ToString();
        }
    }
}
