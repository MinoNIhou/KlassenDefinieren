using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto meinAuto = new Auto();
            Auto deinAuto = new Auto();

            meinAuto.alterInJahren = 13;
            meinAuto.marke = "Audi";            

            meinAuto.alterInJahren = 1;
            meinAuto.marke = "Portsche";


            Console.WriteLine("Mein Auto fährt aktuell {0} km/h", meinAuto.SagAktuelleGeschwindigkeit());
            Console.WriteLine("Dein Auto fährt aktuell {0} km/h", deinAuto.SagAktuelleGeschwindigkeit());
            meinAuto.BeschleunigeAuf100Kmh();
            deinAuto.BeschleunigeAuf100Kmh();
            Console.WriteLine("Mein Auto fährt aktuell {0} km/h", meinAuto.SagAktuelleGeschwindigkeit());
            Console.WriteLine("Dein Auto fährt aktuell {0} km/h", meinAuto.SagAktuelleGeschwindigkeit());
            Console.ReadKey();


        }
    }
}
