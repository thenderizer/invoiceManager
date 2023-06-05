using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace invoiceManager.Domain
{
    [PrimaryKey("ProductId", "InvoiceId")]
    public class InvoiceProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float PriceAfterDiscount { get; set; }

    }
}