using System.Collections.Generic;
using OrderIt.Core.Entities;

namespace OrderIt.Application
{
    internal class MenuService : IMenuService
    {
        private readonly IRepository repository;

        public MenuService(IRepository repository)
        {
            this.repository = repository ?? throw new System.ArgumentNullException(nameof(repository));
        }

        public IList<Food> GetFoods()
        {
            return this.repository.GetAllAsync<Food>().Result;
        }
    }
}