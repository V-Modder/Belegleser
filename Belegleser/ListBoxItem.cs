using System;
using System.Collections.Generic;
using System.Text;

namespace Belegleser
{
    class ListBoxItem
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ListBoxItem()
        {
        }

        public ListBoxItem(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
