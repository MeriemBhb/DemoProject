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
            Largeur = largeur;
        }
    }
}
