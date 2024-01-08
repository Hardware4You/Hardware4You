using Hardware4You.Models;

namespace Hardware4You.Data
{
    public interface IOrderStatusLogService
    {
        IEnumerable<OrderStatusLog> GetLogs();
        Task InsertLogAsync(OrderStatusLog orderStatusLog);
    }
}
