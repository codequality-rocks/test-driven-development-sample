using System.Collections.Generic;

namespace OrderIt.Core.Entities
{
    public class Menu
    {
        public IList<Food> Food { get; set; }
        public IList<Beverage> Beverages { get; set; }
    }
}