namespace CorazonDeCafeStockManager.App.EntityData
{
    public class ProductData
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string? Category { get; set; }
        public int TypeId { get; set; }
        public string? Type { get; set; }
        public int Active { get; set; }
        public int Status { get; set; }
        public string? Imagen { get; set; }
    }
}