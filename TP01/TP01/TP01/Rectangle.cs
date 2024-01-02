using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Rectangle : Forme
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Longueur = largeur;
        }

        public override double Aire => CalculerAire();
        public override double Perimetre => CalculerPerimetre();

        public override double CalculerAire() // longueur = 4 , largeur = 3

        {
            return Longueur * Largeur;
        }

        public override double CalculerPerimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        public override string ToString()
        {
            return $"Rectangle - Longueur: {Longueur}, Largeur: {Largeur}{Environment.NewLine}{base.ToString()}";
        }



    }
}
