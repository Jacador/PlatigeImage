using PlatigeImage.Models.Enums;
using PlatigeImage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PlatigeImage.View.ViewModels.Invoice
{
    public class InvoiceVM
    {
        private CustomerVM? _customer;
        private DateTime _issueDate = DateTime.Now;

        public int Id { get; set; }
        public int Number { get; set; } = 0;

        public string DisplayedNumber => Number == 0 ? "(AUTO)" : Number.ToString();
        public string FullNumber => $"FS/{DisplayedNumber}/{IssueDate.Year}";

        public DateTime SaleDate { get; set; } = DateTime.Now;

        public DateTime IssueDate
        {
            get => _issueDate;
            set
            {
                if (_issueDate.Year != value.Year)
                    Number = 0;
                _issueDate = value;
            }
        }

        public string Description { get; set; } = string.Empty;
        public Currency Currency { get; set; } = Currency.PLN;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;
        public double AmountToPay => Math.Round(InvoicePositions.Sum(ip => ip.Gross), 2);
        public string ToPay => $"{AmountToPay:F2} {Enum.GetName(Currency)}";
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        public CustomerVM? CustomerLookup
        {
            get => _customer;
            set
            {
                _customer = value;
                if (_customer != null)
                {
                    CustomerId = _customer.Id;
                    CustomerName = _customer.Name;
                }
                    
            }
        }

        public List<InvoicePositionVM> InvoicePositions { get; set; } = new ();
    }
}
