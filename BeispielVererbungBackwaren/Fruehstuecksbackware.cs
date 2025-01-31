using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielVererbungBackwaren
{
    internal class Fruehstuecksbackware :Backware
    {
        protected double _abkuehlDauer;

        public Fruehstuecksbackware(string name, double verkaufspreis, double abkuehlDauer) : base(name, verkaufspreis)
        {
            _abkuehlDauer = abkuehlDauer;
        }
    }
}
