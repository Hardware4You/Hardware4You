using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public class OrdersStatusService : IOrdersStatusService
    {
        readonly private OrdersStatusContext _context;

        public OrdersStatusService(OrdersStatusContext context)
        {
            _context = context;
        }

        public IEnumerable<OrdersStatus> GetOrdersStatus()
        {
            try
            {
                return _context.OrdersStatus.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteOrderStatus(long orderId)
        {
            try
            {
                OrdersStatus ordersStatus = _context.OrdersStatus.Find(orderId);
                if (ordersStatus != null)
                {
                    _context.OrdersStatus.Remove(ordersStatus);
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task InsertOrderStatusAsync(OrdersStatus orderStatus)
        {
            try
            {
                _context.OrdersStatus.Add(orderStatus);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OrdersStatus GetOrderStatusById(long orderId)
        {
            try
            {
                return _context.OrdersStatus.FirstOrDefault(o => o.OrderID == orderId);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateOrderStatus(OrdersStatus orderStatus)
        {
            try
            {
                _context.Entry(orderStatus).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
