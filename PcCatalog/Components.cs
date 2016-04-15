using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Components
    {
        private string name;
        private decimal price;


        public Components(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Components(string details, string name, decimal price) : this(name, price)
        {
            this.Details = details;

        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The component need to have name !!");
                }
                name = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number!!");
                }
                price = value; }
        }
        public string Details { get; set; }

        public override string ToString()
        {
            string parts = "Model:  " +   this.name + "\n";
            parts += "Details:  " + this.Details + "\n";
            parts += "Price:  " + this.price + "\n";
            return parts;

        }
    }
}
