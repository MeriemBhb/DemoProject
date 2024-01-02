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
    }
}
