using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз6_часть3
{
    internal class Exhibit
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Exhibit(string name)
        {
            _name = name;
        }

    }
}
