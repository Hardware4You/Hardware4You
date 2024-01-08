using Hardware4You.Models;

namespace Hardware4You.Data
{
    public class OrderStatusLogService : IOrderStatusLogService
    {
        readonly private OrderStatusLogContext _context;

        public OrderStatusLogService(OrderStatusLogContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderStatusLog> GetLogs()
        {
            try
            {
                return _context.OrderStatusLog.ToList();
            }
            catch
            {
                throw;
            }
        }

        public async Task InsertLogAsync(OrderStatusLog orderLog)
        {
            try
            {
                _context.OrderStatusLog.Add(orderLog);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
