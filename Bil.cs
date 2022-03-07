using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingsBlahaAllaÖvningar
{
    internal class Bil
    {
        public double hastighet = 0;
        private double acceleration;
        private string Namn;
        private int BilNummer;
        public Bil (double acc, string bilNamn, int bilNr)
        {
            BilNummer = bilNr;
            Namn = bilNamn;
            acceleration = acc;
            // Om en spelare har hög acceleration
            // så straffas den med att börja med negativ hastighet
            if (acceleration > 0.6)
            {
                hastighet = -1;
            }
            else
            {
                hastighet = 0;
            }
        }
        public void Gasa()
        {
            hastighet += acceleration;
            Console.WriteLine(Namn.ToString() + " - Gasade upp till: " + hastighet.ToString());
        }
        public void Bromsa()
        {
            hastighet -= acceleration;
            Console.WriteLine(Namn.ToString() + " - Bromsade ned till: " +hastighet.ToString());
        }
        public string BilNamn()
        {
            return Namn;
        }
        public int ListNr()
        {
            return BilNummer;
        }
        public override string ToString()
        {
            return "BilNamn: " + Namn + " ||| Hastighet: " + hastighet.ToString() + " ||| BilNr: " + BilNummer;
        }
    }
}
