using System.ComponentModel.DataAnnotations.Schema;

namespace invoiceManager.Domain
{
    public class Refund
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }
        public ICollection<InvoiceProduct> RefundedProducts { get; set; }
        public  int CostumerId { get; set; }
        [ForeignKey("CostumerId")]
        public Costumer Costumer { get; set; }
        public Refund()
        {
            RefundedProducts= new List<InvoiceProduct>();
        }
    }
}
