using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrintWebShop.Controllers;
using PrintWebShop.Data.Repositories;
using PrintWebShop.Data.Entities;

namespace PrintWebShop.Services
{
    public class OrderService : IOrderService
    {
        public IGenericRepository<Parameter> OrderRepository { get; set; }
    }
}