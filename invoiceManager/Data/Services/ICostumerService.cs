using invoiceManager.Domain;

namespace invoiceManager.Data.Services
{
    public interface ICostumerService
    {
        public void AddProduce(Product product);
        public void UpdateProduce(Product product);
        public void DeleteProduce(Product product);
        public IEnumerable<Product> GetAll();
        public Product GetById(int id);
    }
}
