using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielVererbungBackwaren
{
    enum Farben
    {
        None = 0,
        Weiß = 14,
        Rot = 2
    }
    internal class Sueßbackware : Fruehstuecksbackware
    {
        private double _zuckerGehalt;
        private double _lagerTemperatur;
        

        public Sueßbackware(string name, double verkaufspreis, double abkuehlDauer, double zuckerGehalt,double lagerTemperatur) : base(name, verkaufspreis, abkuehlDauer)
        {
            _zuckerGehalt = zuckerGehalt;
            _lagerTemperatur = lagerTemperatur;
        }

        public static void FarbeAusgeben(Farben farben) 
        {
            Console.WriteLine((int) farben);
        }
    }
}
