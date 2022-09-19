using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    public class Auto
    {
        public string marke;
        public int alterInJahren;
        private int aktuelleGeschwindigkeit;

        public void BeschleunigeAuf100Kmh()
        {
            aktuelleGeschwindigkeit = 100;

            if (this.IstSchnell())
            {
                Console.WriteLine("Habe schnell beschleunigt <3");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt");
            }
        }

        public int SagAktuelleGeschwindigkeit()
        {
            return aktuelleGeschwindigkeit;
        }

        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }
            else
            {
                return false; 
            }
        } 
    }
}
