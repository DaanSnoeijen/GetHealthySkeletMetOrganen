using System;

namespace GetHealthySkelet
{
    class Product
    {
        public string naam;
        public int calorieën;
        public int totaleVetten;
        public int verzadigdeVetten;
        public int koolhydraten;
        public int suikers;
        public double eiwitten;
        public double zouten;
        public int hoeveelheid;

        public Product(string Naam, int Calorieën, int TotaleVetten, int VerzadigdeVetten, int Koolhydraten, int Suikers, double Eiwitten, double Zouten, int Hoeveelheid)
        {
            naam = Naam;
            calorieën = Calorieën;
            totaleVetten = TotaleVetten;
            verzadigdeVetten = VerzadigdeVetten;
            koolhydraten = Koolhydraten;
            suikers = Suikers;
            eiwitten = Eiwitten;
            zouten = Zouten;
            hoeveelheid = Hoeveelheid;
        }

        public override string ToString()
        {
            return naam + ", calorieën: " +
                Convert.ToString(calorieën) + ", totale vetten: " +
                Convert.ToString(totaleVetten) + ", gemiddelde vetten: " +
                Convert.ToString(verzadigdeVetten) + ", koolhydraten: " +
                Convert.ToString(koolhydraten) + ", suikers: " +
                Convert.ToString(suikers) + ", eiwitten: " +
                Convert.ToString(eiwitten) + ", zouten: " +
                Convert.ToString(zouten) + ", hoeveelheid: " +
                Convert.ToString(hoeveelheid);
        }
    }
}
