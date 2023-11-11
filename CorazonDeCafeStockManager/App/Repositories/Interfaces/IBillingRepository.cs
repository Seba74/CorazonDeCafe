using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Repositories;

public interface IBillingRepository
{
    Task LoadBillingInfo();
    Task<IEnumerable<Order>> GetAllBillings();
    Task<IEnumerable<Order>> GetAllBillingsByEmployeeId(int id);
    Task<Order> GetBillingById(int id);
    Task<IEnumerable<Order>> GetBillingsByCustomerId(int id);
    Task AddBilling(OrderData order);
    Task<Order> GetLastBilling();
    Task<bool> DeleteBilling(int id);
    Task<Product> GetProductPop();
    Task<Customer> GetCustomerPop();
    Task<PaymentMethod> GetPaymentMethodPop();
    Task<int> GetLastMonthBillings();
    Task<IEnumerable<OrderStats>> GetBillingsByDateAndEmployeeId(DateTime startDate, DateTime endDate, int? employeeId);
    Task<IEnumerable<OrderCantStats>> GetBillingsCantByDateAndEmployeeId(DateTime startDate, DateTime endDate, int? employeeId);
    Task<IEnumerable<OrderByEmployee>> GetBillingsByEmployee(DateTime startDate, DateTime endDate, int? employeeId);
}
