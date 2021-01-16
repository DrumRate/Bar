using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bar
{
    public class ComplexDrink : AbstractDrink
    {
        private readonly List<AbstractDrink> ingridients = new List<AbstractDrink>();

        public ComplexDrink(string name, List<AbstractDrink> ingridients)
        {
            if (ingridients.Count < 1)
            {
                throw new ArgumentException("Должно быть не менее 1 ингридиента");
            }

            this.name = name;
            this.ingridients = ingridients;
        }

        public override double GetVolume()
        {
            double sum = 0;
            foreach (AbstractDrink ingridient in ingridients)
            {
                sum += ingridient.GetVolume();
            }
            return sum;
        }

        public override double CountPrice()
        {
            double sum = 0;

            foreach (AbstractDrink ingridient in ingridients)
            {
                sum += ingridient.CountPrice();
            }
            return sum;
        }

        public override string GetComposition()
        {
            
            string str = String.Join(", ", ingridients.Select(i => i.GetComposition()));
            if (string.IsNullOrEmpty(str))
            {
                str = "Нет компонентов";
            }

            return String.Format($"{name} ({GetVolume()} ml) [{CountPrice()} RUB] : {str}");

        }
    }
}
