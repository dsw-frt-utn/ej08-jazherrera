using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private string description;

        public Product(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void ModifyDescription(string newDescription)
        {
            description = newDescription;
        }
    }
}

