using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace invoiceManager.Domain
{
    [PrimaryKey("ProductId", "RefundId")]
    public class RefundProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int RefundId { get; set; }
        public Refund Refund { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float PriceAfterDiscount { get; set; }

    }
}


