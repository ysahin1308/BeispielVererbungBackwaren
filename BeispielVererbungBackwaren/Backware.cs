using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeispielVererbungBackwaren
{
    public class Backware
    {
        protected string _name;
        protected double _verkaufsPreis;

        public Backware(string name, double verkaufspreis) 
        {
            _name = name;
            _verkaufsPreis = verkaufspreis;
        }
        public string Name {  get { return _name; } protected set { _name = value; } }

        public double Verkaufspreis { get { return _verkaufsPreis; } protected set { _verkaufsPreis = value; } }
    }
}