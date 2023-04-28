using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз6_часть3
{  public enum Availability
    {
        inStock,
        outStock
    }
    internal class Exhibition
    {
        private int _quantity;
        private Availability _availability = Availability.inStock;
        private Exhibit _exhibits;

        public int Quantity
        {
            get => _quantity;
        }

        public Availability Availability
        {
            get => _availability;
        }

        private Exhibit Exhibit
        {
            get => _exhibits;
        }

        public string ExhibitName
        {
            get { return Exhibit != null ? Exhibit.Name : "Не назначено"; }
        }

        public Exhibition(int quantity, Availability availability, Exhibit exhibits)
        {
            _quantity = quantity;
            _availability = availability;
            _exhibits = exhibits;
        }
    }
}
