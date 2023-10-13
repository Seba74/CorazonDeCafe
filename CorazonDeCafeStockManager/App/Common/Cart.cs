using CorazonDeCafeStockManager.App.EntityData;
using CorazonDeCafeStockManager.App.Models;

namespace CorazonDeCafeStockManager.App.Common
{
    public static class Cart
    {
        public static OrderData? Order { get; set; }
        public static Customer? Customer { get; set; }
        public static void ClearCart()
        {
            Order = null;
            Customer = null;
        }

        public static void AddProductToCart(OrderProductData orderProduct)
        {
            Order ??= new OrderData();
            Order.Products ??= new List<OrderProductData>();
            OrderProductData? orderProductData = Order.Products.FirstOrDefault(o => o.ProductId == orderProduct.ProductId);
            if (orderProductData != null) orderProductData.Amount += orderProduct.Amount;
            else Order.Products = Order.Products.Append(orderProduct);

            Order.Subtotal += orderProduct.Price * orderProduct.Amount;
            Order.Iva = Order.Subtotal * 0.19;
            Order.TotalPrice = Order.Subtotal + Order.Iva;
        }

        public static void RemoveProductFromCart(OrderProductData orderProduct)
        {
            OrderProductData? order = Order!.Products!.FirstOrDefault(o => o.ProductId == orderProduct.ProductId);
            if (order != null) Order.Products = Order.Products!.Where(o => o.ProductId != orderProduct.ProductId);

            Order.Subtotal -= orderProduct.Price * orderProduct.Amount;
            Order.Iva = Order.Subtotal * 0.19;
            Order.TotalPrice = Order.Subtotal + Order.Iva;
        }
        public static void UpdateProductFromCart(OrderProductData orderProduct, int amount)
        {
            OrderProductData? order = Order!.Products!.FirstOrDefault(o => o.ProductId == orderProduct.ProductId);
            if (order != null)
            {
                Order.Subtotal -= order.Price * order.Amount;
                Order.Subtotal += order.Price * amount;
                Order.Iva = Order.Subtotal * 0.19;
                Order.TotalPrice = Order.Subtotal + Order.Iva;

                order.Amount = amount;
            }
            if (order!.Amount <= 0) Order.Products = Order.Products!.Where(o => o.ProductId != orderProduct.ProductId);
        }
    }
}
