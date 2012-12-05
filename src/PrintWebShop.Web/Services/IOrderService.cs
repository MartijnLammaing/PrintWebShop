using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrintWebShop.Data.Repositories;
using PrintWebShop.Data.Entities;

namespace PrintWebShop.Controllers
{
    public interface IOrderService
    {
        IGenericRepository<Parameter> OrderRepository {get;set;}
    }
}
