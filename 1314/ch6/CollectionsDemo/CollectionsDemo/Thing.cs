using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    class Thing
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
