using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielVererbungBackwaren
{
    internal class Salzbackware : Fruehstuecksbackware
    {
        private double _salzGehalt;

        public Salzbackware(string name, double verkaufspreis, double abkuehlDauer,double salzgehalt) : base(name,verkaufspreis,abkuehlDauer)
        {
            _salzGehalt = salzgehalt;
        }
    }
}
