using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHealthySkelet
{
    class Gebruiker
    {
        public int geslacht;
        public int gewicht;
        public double lengte;
        public int leeftijd;
        public int sportPerWeek;
        public bool werk;
        public bool vegan;
        public bool activiteit = false;
        public double BMI;

        public Gebruiker(int Geslacht, int Gewicht, double Lengte, int Leeftijd, int SportPerWeek, bool Werk, bool Vegan)
        {
            geslacht = Geslacht;
            gewicht = Gewicht;
            lengte = Lengte;
            leeftijd = Leeftijd;
            sportPerWeek = SportPerWeek;
            werk = Werk;
            vegan = Vegan;
        }
    }
}
