using System.Diagnostics;

namespace ProductsModels
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Tax { get; set; }

        public decimal Total
        {
            get
            {
                return Price + (Price * Tax);
            }
        }
        public DateTime CreatedAt { get; set; }
        public ProductDTO()
        {
            CreatedAt = DateTime.Now;
        }
        public ProductDTO(int Id, string ProductName, decimal Price,
            int Quantity, decimal Tax, DateTime CreatedAt)
        {
            this.Id = Id;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Tax = Tax;
            this.CreatedAt = CreatedAt;

        }

    }
}
