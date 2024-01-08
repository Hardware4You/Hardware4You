using Hardware4You.Models;

namespace Hardware4You.Data
{
    public interface IOrdersService
    {
        IEnumerable<Orders> GetOrders();
        void DeleteOrder(long orderId);
        Task InsertOrderAsync(Orders order);
        Orders GetOrderById(long orderId);
        void UpdateOrder(Orders order);
    }
}
