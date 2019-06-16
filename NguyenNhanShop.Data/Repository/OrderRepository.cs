using NguyenNhanShop.Data.Infrastructure;
using NguyenNhanShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhanShop.Data.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {

    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
