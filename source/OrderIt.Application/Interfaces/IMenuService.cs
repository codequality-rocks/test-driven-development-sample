using System.Collections.Generic;
using OrderIt.Core.Entities;

namespace OrderIt.Application
{
    public interface IMenuService
    {
        IList<Food> GetFoods();
    }
}