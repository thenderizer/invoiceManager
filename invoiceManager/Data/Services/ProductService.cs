using invoiceManager.Domain;

namespace invoiceManager.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository) 
        {
            _repository=repository;
        }
        public void AddProduct(Product product)
        {
            _repository.Create(product);
        }

        public void DeleteProduct(Product product)
        {
            _repository.Delete(product);
            _repository.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(int SKU)
        {
            return _repository.table.FirstOrDefault(x => x.Sku == SKU);
        }

        public void UpdateProduct(Product product)
        {
            _repository.Update(product);
            _repository.SaveChanges();
        }
    }
}
