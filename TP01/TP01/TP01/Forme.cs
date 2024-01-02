using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }

        public abstract double CalculerAire();
        public abstract double CalculerPerimetre();

        public override string ToString()
        {
            return $"Aire = {Aire}{Environment.NewLine}Périmétre = {Perimetre}{Environment.NewLine}";
        }

    }
}
