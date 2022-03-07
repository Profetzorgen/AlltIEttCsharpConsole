using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingsBlahaAllaÖvningar
{
    public class Rektangel
    {
        public int Bredd;
        public int Höjd;
        public Rektangel()
        {

        }
        public Rektangel(int b, int h)
        {
            Bredd = b;
            Höjd = h;
        }
        public int Area()
        {
            return Bredd * Höjd;
        }
        public int Omkrets()
        {
            return (Bredd*2) + (Höjd*2);
        }
        public override string ToString()
        {
            return "Arean på Rektangeln är: " + Area().ToString() +
                " och omkretsen är: " + Omkrets().ToString();
        }
    }
}
