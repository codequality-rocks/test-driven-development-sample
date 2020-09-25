using System.Collections.Generic;
using start.Entities;

namespace start
{
    internal interface IOrderService
    {
        IList<Order> Orders { get; set; }
    }
}