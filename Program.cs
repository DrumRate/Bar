using System;
using System.Collections.Generic;

namespace Bar
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDrink orangeDrink = new BaseDrink("Апельсиновый сок", 100, 200);
            BaseDrink waterDrink = new BaseDrink("Вода", 50, 200);
            AlcoholDrink beer = new AlcoholDrink("Пиво светлое", 150, 500, 1.2);

            List<AbstractDrink> margaritaComponents = new List<AbstractDrink>();
            margaritaComponents.Add(new AlcoholDrink("Водка", 150, 20, 1.5));
            margaritaComponents.Add(new AlcoholDrink("Текила", 170, 20, 1.75));
            margaritaComponents.Add(new BaseDrink("Сок лайма", 100, 30));

            ComplexDrink margarita = new ComplexDrink("Маргарита", margaritaComponents);

            List<AbstractDrink> drinks = new List<AbstractDrink>();
            drinks.Add(orangeDrink);
            drinks.Add(waterDrink);
            drinks.Add(beer);
            drinks.Add(margarita);

            foreach (AbstractDrink drink in drinks)
            {
                Console.WriteLine($"{drink.name}, {drink.CountPrice()} \n{drink.GetComposition()}\n\n");
            }

        }
    }
}
