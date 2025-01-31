using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielVererbungBackwaren
{
    internal class Brot : Backware
    {
        private string _mehlSorte;
        private double _gewicht;
        

        public Brot(string name, double verkaufspreis,string mehlsorte,double gewicht) : base(name,verkaufspreis)
        {
            _mehlSorte = mehlsorte;
            _gewicht = gewicht;
        }
    }
}
