namespace invoiceManager.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public int Sku { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public ICollection<InvoiceProduct> Invoices { get; set; }
    }
}
