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
    }
}
