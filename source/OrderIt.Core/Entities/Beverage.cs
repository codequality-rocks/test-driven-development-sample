using System;

namespace OrderIt.Core.Entities
{
    public class Beverage
    {
        public Guid Id { get; set;}
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public int Price { get; set;}
    }
}