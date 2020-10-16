using System;
using System.Collections.Generic;

namespace GetHealthySkelet
{
    class ProductContainer
    {
        public List<Product> ProductList = new List<Product>();

        Random random = new Random();

        //Deze methode is alleen voor testing. Daarom staat deze niet in mijn klassendiagram.
        public void createProduct(int Hoeveelheid)
        {
            int hoeveelheid = Hoeveelheid;

            Product product = new Product(
                ProductList.Count.ToString(),
                random.Next(1000),
                random.Next(50),
                random.Next(10),
                random.Next(150),
                random.Next(50),
                random.Next(20),
                random.Next(3),
                hoeveelheid);

            ProductList.Add(product);
        }
    }
}
