using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public class BaseDrink : AbstractDrink
    {
        protected double basePrice;
        protected double volume;
        public BaseDrink(string name, double price, double volume) 
        {
            this.name = name;
            basePrice = price;
            this.volume = volume;
        }
        public override double GetVolume()
        {
            return volume; 
        }

        public override double CountPrice()
        {
            return basePrice * volume / 100;
        }

        public override string GetComposition()
        {
            return String.Format($"{name}: ({volume} ml) [{CountPrice()} RUB]");
        }
    }
}
