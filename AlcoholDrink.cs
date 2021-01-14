using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
    public class AlcoholDrink : BaseDrink
    {
        private double addTax;

        public AlcoholDrink(string name, double basePrice, double volume) : base(name, basePrice, volume)
        {
            addTax = 1.5;
        }

        public AlcoholDrink(String name, double basePrice, double volume, double addTax) : base(name, basePrice, volume)
        {
            this.addTax = addTax;
        }

        public override double GetVolume()
        {
            return this.volume;
        }

        public void SetBasePrice(double basePrice)
        {
            this.basePrice = basePrice;
        }

        public override double CountPrice()
        {
            return this.basePrice * this.volume * this.addTax / 100;
        }

        public override string GetComposition()
        {
            return String.Format($"{base.GetComposition()} (наценка в размере {addTax} уже включена в стоимость)");
        }
    }
}
