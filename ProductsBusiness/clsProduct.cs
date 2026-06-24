using ProductsDataAccess;
using ProductsModels;

namespace ProductsBusiness
{
    public class clsProduct
    {
        public ProductDTO productDTO
        {
            get
            {
                return new ProductDTO()
                { 
                    Id = Id,
                    ProductName = ProductName,
                    Price = Price,
                    Quantity = Quantity,
                    Tax = Tax,
                    CreatedAt = CreatedAt 
                };
            }
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Tax { get; set; }
        public DateTime CreatedAt { get; set; }

        enum enMode
        {
            AddNew, Update
        }
        enMode Mode = enMode.AddNew;
        public clsProduct()
        {
            this.Id = -1;
            this.ProductName = "";
            this.Price = 0;
            this.Quantity = 0;
            this.Tax = 0;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsProduct(ProductDTO product)
        {
            this.Id = product.Id;
            this.ProductName = product.ProductName;
            this.Price = product.Price;
            this.Quantity = product.Quantity;
            this.Tax = product.Tax;
            this.CreatedAt = product.CreatedAt;
            Mode = enMode.Update;
        }

        public static List<ProductDTO> GetProducts()
        {
            return clsProductData.GetProducts();
        }
        public static List<ProductDTO> Search(string name)
        {
            return clsProductData.Search(name);
        }
        
        public static clsProduct GetInfoByID(int ID)
        {
            ProductDTO product = clsProductData.GetInfoByID(ID);
            if (product != null)
                return new clsProduct(product);
            return null;
        }
        public bool _AddNewProduct()
        {
            this.Id = clsProductData.AddNewProduct(productDTO);
            return this.Id != -1;
        }
        public bool _UpdateProduct()
        {
            return clsProductData.UpdateProduct(productDTO);
        }
        public bool Delete()
        {
            return clsProductData.Delete(this.Id);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    Mode = enMode.Update;
                    return _AddNewProduct();
                case enMode.Update:
                    return _UpdateProduct();
                default:
                    return false;
            }

        }
    }
}
