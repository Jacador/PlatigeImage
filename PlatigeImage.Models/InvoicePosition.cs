using PlatigeImage.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.Models
{
    public class InvoicePosition : IDatabaseEntity
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public required string Name { get; set; }
        public int Quantity { get; set; } = 1;
        public double UnitPrice { get; set; } = 0;
        public double Net { get; set; } = 0;
        public double Vat { get; set; } = 0;
        public double Gross { get; set; } = 0;
        public double VatRate { get; set; } = 0;
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; } = null!;
    }
}
