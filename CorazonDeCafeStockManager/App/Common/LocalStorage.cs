using CorazonDeCafeStockManager.App.Models;
using Type = CorazonDeCafeStockManager.App.Models.Type;

namespace CorazonDeCafeStockManager.App.Common
{
    public static class LocalStorage
    {
        public static List<Product>? Products { get; set; }
        public static List<Customer>? Customers { get; set; }
        public static List<Employee>? Employees { get; set; }
        public static List<Role>? Roles { get; set; }
        public static List<Category>? Categories { get; set; }
        public static List<PaymentMethod>? PaymentMethods { get; set; }
        public static List<BillingType>? BillingTypes { get; set; }
        public static List<Order>? Orders { get; set; }
        public static List<Type>? Types { get; set; }
    }
}