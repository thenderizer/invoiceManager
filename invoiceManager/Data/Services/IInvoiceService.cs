using invoiceManager.Domain;

namespace invoiceManager.Data.Services
{
    public interface IInvoiceService
    {
        public void AddInvoice(Invoice invoice);
        public void UpdateInvoice(Invoice invoice);
        public void DeleteInvoice(Invoice invoice);
        public IEnumerable<Invoice> GetAll();
        public Invoice GetById(int id);
    }
}
