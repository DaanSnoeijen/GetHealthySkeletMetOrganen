using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHealthySkelet
{
    class GebruikerContainer
    {
        public List<Gebruiker> GebruikerList = new List<Gebruiker>();

        public void AddGebruiker(int geslacht, int gewicht, int lengte, int leeftijd, int sportPerWeek, bool werk, bool vegan)
        {
            Gebruiker g = new Gebruiker(geslacht, gewicht, lengte, leeftijd, sportPerWeek, werk, vegan);
            GebruikerList.Add(g);
        }
    }
}
