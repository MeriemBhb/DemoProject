using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Triangle : Forme
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Aire => CalculerAire();
        public override double Perimetre => CalculerPerimetre();

        public override double CalculerAire()
        {
            // Utilisez la formule de Héron pour calculer la surface d'un triangle
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double CalculerPerimetre()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return $"Triangle - A: {A}, B: {B}, C: {C}{Environment.NewLine}{base.ToString()}";
        }
    }
}
