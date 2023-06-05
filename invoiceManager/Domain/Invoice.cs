using System.ComponentModel.DataAnnotations.Schema;

namespace invoiceManager.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CostumerId { get; set; }
        [ForeignKey("CostumerId")]
        public Costumer Costumer { get; set; }
        public ICollection<InvoiceProduct> Products { get; set; }
        public float? USDPrice { get; set; }
        public Currency Currency { get; set; }
        public float TotalPrice { get; set; }
        public float Discount { get; set; }
        public float TotalAfterDiscount { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCanceled { get; set; } = false;
        public bool HasRefunds { get; set; } = false;
        public float PaidAmount { get; set; }
        public int RefundId { get; set; }
        [ForeignKey("RefundId")]
        public Refund Refund { get; set; }
        public bool IsFullyPaid{ get; set; }


        public Invoice()
        {
            Products = new List<InvoiceProduct>();
        }
    }
    public enum Currency{
        EGP,
        USD
    }
   
}
