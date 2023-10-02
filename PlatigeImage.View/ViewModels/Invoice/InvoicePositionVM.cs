using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.ViewModels.Invoice
{
    public class InvoicePositionVM : INotifyPropertyChanged
    {
        private double _vatRate = 0.23;
        private int _quantity = 1;
        private double _unitPrice = 0;
        private double _net;
        private double _vat;
        private double _gross;

        public int Id { get ; set; }
        public string Name { get; set; } = string.Empty;

        public double VatRate
        {
            get => _vatRate;
            set
            {
                _vatRate = value;
                CalculateGross();
            }
        }

        public int Quantity {
            get => _quantity;
            set
            {
                _quantity = value;
                CalculateGross();
            }
        }

        public double UnitPrice
        {
            get => _unitPrice;
            set
            {
                _unitPrice = value;
                CalculateGross();
            }
        }

        public double Net
        {
            get => _net;
            set
            {
                _net = value;
                CalculateGross();
            }
        }

        public double Vat
        {
            get => _vat;
            set
            {
                _vat = value;
                CalculateGross();
            }
        }

        public double Gross
        {
            get => _gross;

            set
            {
                _gross = value;
                CalculateGross();
            }
        }

        public int InvoiceId { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CalculateGross()
        {
            _net = Math.Round(_unitPrice * _quantity, 2);
            _vat = Math.Round(_net * _vatRate, 2);
            _gross = Math.Round(_net + _vat, 2);
            OnPropertyChanged(nameof(Gross));
        }
    }
}
