using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз6_часть3
{
    internal class ExhibitionDatabase
    {
        private Random _random = new Random();

        internal List<Exhibition> Exhibits { get; private set; }
        public void Initialize()
        {
            Exhibits = new List<Exhibition>
            {
                new Exhibition(1, Availability.inStock, new Exhibit("Картина Черный Квадрат")),
                new Exhibition(3, Availability.inStock, new Exhibit("Древнегреческие скульптуры")),
                new Exhibition(1, Availability.outStock, new Exhibit("Картина Грачи прилетели")),
                new Exhibition(1, Availability.outStock, new Exhibit("Картина Звездная ночь")),
                new Exhibition(7, Availability.inStock, new Exhibit("Глиняные кувшины"))
            };
        }
    }
}
    
