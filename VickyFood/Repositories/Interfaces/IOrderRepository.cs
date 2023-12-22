using VickyFood.Models;

namespace VickyFood.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
