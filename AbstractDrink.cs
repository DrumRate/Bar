using System;
using System.Collections.Generic;
using System.Text;

namespace Bar
{
   public abstract class AbstractDrink
    {
        public string name;
        public abstract double GetVolume();
        public abstract double CountPrice();
        public abstract string GetComposition();
    }
}
