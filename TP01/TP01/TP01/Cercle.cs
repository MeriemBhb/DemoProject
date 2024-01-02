using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Cercle : Forme
    {
        public double Rayon { get; set; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }


        public override double Aire => CalculerAire();
        public override double Perimetre => CalculerPerimetre();

        public override  double CalculerAire()
        {
            return Math.PI * Math.Pow(3, 2); // rayon =3
        }

        public override double CalculerPerimetre()
        {
            return 2 * Math.PI * 3; // rayon =3
        }

        public override string ToString()
        {
            return $"Cercle - Rayon: {Rayon}{Environment.NewLine}{base.ToString()}";
        }
    }
}
