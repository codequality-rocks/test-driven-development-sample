using System;
using System.Collections.Generic;

namespace OrderIt.Core.Entities
{
    public class Food
    {
        public Guid Id { get; set;}
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public IList<string> Ingredients { get; set; }
        public int Price { get; set;}
    }
}