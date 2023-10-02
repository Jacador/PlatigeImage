using PlatigeImage.Models.Enums;

namespace PlatigeImage.View
{
    public class ContractorListVM
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TinPrefix { get; set; }
        public string Tin { get; set; }
        public string REGON { get; set; }
        public string PIN { get; set; }
        public ContractorKind Kind { get; set; }
        public ContractorStatus Status { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
    }

}