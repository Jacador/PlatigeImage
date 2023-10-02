using PlatigeImage.Models.Enums;

namespace PlatigeImage.View
{
    public class ContractorVM
    {
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public CountryCode TinPrefix { get; set; } = CountryCode.PL;
        public string Tin { get; set; } = string.Empty;
        public ContractorKind Kind { get; set; } = ContractorKind.National;
        public ContractorStatus Status { get; set; } = ContractorStatus.BusinessEntity;
        public string Adress { get; set; } = string.Empty;
        public string Country { get; set; } = CountryCode.PL.GetDescription();
        public string Phone { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public bool Recipient { get; set; } = true;
        public bool Vendor { get; set; }
        public bool RelatedEntity { get; set; }
        public bool ActiveVat { get; set; } = true;
        public bool InLiquidation { get; set; }
    }

}