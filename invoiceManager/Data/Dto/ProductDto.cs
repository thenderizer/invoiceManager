using invoiceManager.Domain;

namespace invoiceManager.Data.Dto
{
    
    public class ProductCreateDto
    {
       
        public int Sku { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

    }
    public class ProductReadDto : ProductCreateDto 
    {
        public int id { get; set; }
        public ICollection<InvoiceProduct> Invoices { get; set; }
    }


}
