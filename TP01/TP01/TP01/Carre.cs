using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Carre : Forme
    {
        public double Longueur { get; set; }

       public Carre(double longueur)
        {
            Longueur = longueur;
        }

        public override double Aire => CalculerAire();
        public override double Perimetre => CalculerPerimetre();

        public override double CalculerAire()
        {
            return Math.Pow(Longueur, 2);
        }

        public override double CalculerPerimetre()
        {
            return 4 * Longueur;
        }

        public override string ToString()
        {
            return $"Carré - Longueur: {Longueur}{Environment.NewLine}{base.ToString()}";
        }

    }
}
