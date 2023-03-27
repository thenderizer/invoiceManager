using invoiceManager.Domain;

namespace invoiceManager.Data.Services
{
    public interface IProductService
    {
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(Product product);
        public IEnumerable<Product> GetAll();
        public Product GetById(int id);
    }
}
