using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielVererbungBackwaren
{
    internal class Konditoreiware : Backware
    {
        private double _kuehlTemperatur;
        private DateTime _minHaltbarkeit;
        public Konditoreiware(string name, double verkaufspreis, double kuehlTemperaturhlDauer, DateTime minHaltbarkeit) : base(name, verkaufspreis)
        {
            _kuehlTemperatur = kuehlTemperaturhlDauer;
            _minHaltbarkeit = minHaltbarkeit;
        }
    }
}
