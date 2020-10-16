using System;
using System.Collections.Generic;

namespace GetHealthySkelet
{
    class InvoerContainer
    {
        public List<Invoer> InvoerList = new List<Invoer>();

        public void AddInvoer(double calorieën, double totaleVetten, double verzadigdeVetten, double koolhydraten, double suikers, double eiwitten, double zouten)
        {
            Invoer invoer = new Invoer(calorieën, totaleVetten, verzadigdeVetten, koolhydraten, suikers, eiwitten, zouten);
            InvoerList.Add(invoer);
        }
    }
}
