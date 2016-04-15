using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcCatalog
{
    class Computer
    {
        private string name;
        private List<Components> component;


        public Computer(string name, List<Components> component) 
        {
            this.Name = name;
            this.Component = component;
        }
        public List<Components> Component
        {
            get { return this.component; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Component must be atleast one!!");
                }
                component = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must be atleast one charachter !!");
                }
                name = value;
            }
        }
        public decimal Price
        {
            get { return this.TotalPrice(); }
            set { this.Price = TotalPrice(); }
            
        }
        public decimal TotalPrice()
        {
           // List<Components> totalPrice = new List<Components>();
            decimal result = 0M;
            foreach (var comp in component)
            {
                result += comp.Price;
            }
            return result;
        }
        public override string ToString()
        {
            string obj = "Name " + this.name + "\n";
            obj += "Price " + this.Price + "\n";
            foreach (var comp in Component)
            {
                Console.WriteLine(comp);
            }
            return obj;
        }

    }
}
