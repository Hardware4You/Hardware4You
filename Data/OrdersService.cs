using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public class OrdersService : IOrdersService
    {
        readonly private OrdersContext _context;

        public OrdersService(OrdersContext context)
        {
            _context = context;
        }

        public IEnumerable<Orders> GetOrders()
        {
            try
            {
                return _context.orders.Include(o => o.SelectedProducts).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteOrder(long orderId)
        {
            try
            {
                Orders order = _context.orders.Find(orderId);
                if (order != null)
                {
                    _context.orders.Remove(order);
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task InsertOrderAsync(Orders order)
        {
            try
            {
                _context.orders.Add(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Orders GetOrderById(long orderId)
        {
            try
            {
                return _context.orders.Include(o => o.SelectedProducts).FirstOrDefault(o => o.OrderID == orderId);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateOrder(Orders order)
        {
            try
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
