using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.EntityData
{
    public class OrderData
    {
        public int? Id { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerCuil { get; set; }
        public int BillingType { get; set; }
        public int PaymentMethod { get; set; }
        public IEnumerable<OrderProductData>? Products { get; set; }
        public int Status { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double TotalPrice { get; set; }
    }
    public class OrderProductData
    {
        public int ProductId { get; set; }
        public int? Stock { get; set; }
        public Product? Product { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}