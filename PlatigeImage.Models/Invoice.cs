using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlatigeImage.DataAccess.Interfaces;
using PlatigeImage.Models.Enums;

namespace PlatigeImage.Models
{
    public class Invoice : IDatabaseEntity
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public int Number { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public string Description { get; set; } = string.Empty;
        public Currency Currency { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Contractor? Customer {get; set; }

        public List<InvoicePosition> InvoicePositions { get; set; } = new ();
    }
}