using System.ComponentModel;
using PlatigeImage.Models.Enums;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Interfaces;

namespace PlatigeImage.Models
{
    [Index(nameof(Country))]
    public class Contractor : IDatabaseEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        [MaxLength(20)]
        public required string Code { get; set; }

        [MaxLength(350)]
        public string Name { get; set; } = string.Empty;

        public CountryCode TinPrefix { get; set; }
        [MaxLength(20)]
        public string Tin { get; set; } = string.Empty;

        public ContractorKind Kind { get; set; }
        public ContractorStatus Status { get; set; }

        [MaxLength(255)]
        public string Adress { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Country { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(127)]
        public string EMail { get; set; } = string.Empty;

        public bool Recipient { get; set; }
        public bool Vendor { get; set; }
        public bool RelatedEntity { get; set; }
        public bool ActiveVat { get; set; }
        public bool InLiquidation { get; set; }
    }



}