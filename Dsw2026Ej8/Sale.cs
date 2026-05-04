using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        private decimal amount;

        public Sale(decimal amount)
        {
            this.amount = amount;
        }

        public decimal GetAmount()
        {
            return amount;
        }

        public void SetAmount(decimal amount)
        {
            this.amount = amount;
        }

        public virtual decimal CalculateTotal()
        {
            return amount;
        }
    }
}
