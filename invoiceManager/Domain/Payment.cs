using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace invoiceManager.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }
        public float PaiedAmount { get; set; }
        public int CosumerId { get; set; }
        public Costumer Costumer { get; set; }

    }
}
