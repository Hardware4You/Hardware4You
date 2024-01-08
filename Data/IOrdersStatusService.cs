using Hardware4You.Models;
namespace Hardware4You.Data
{
    public interface IOrdersStatusService
    {
        IEnumerable<OrdersStatus> GetOrdersStatus();
        void DeleteOrderStatus(long orderId);
        Task InsertOrderStatusAsync(OrdersStatus orderStatus);
        OrdersStatus GetOrderStatusById(long orderId);
        void UpdateOrderStatus(OrdersStatus orderStatus);
    }
}
