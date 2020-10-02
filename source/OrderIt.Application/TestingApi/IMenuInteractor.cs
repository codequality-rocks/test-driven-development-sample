using System.Collections.Generic;
using OrderIt.Core;
using OrderIt.Core.Entities;

namespace OrderIt.Application.TestingApi
{
    public interface IMenuInteractor
    {
        Menu GetMenu();

        IList<Food> GetAllFood();

        Food SelectSpecifcFood();

        IList<Beverage> GetAllBeverages();

        Beverage GetSpecificBeverage();
    }
}