using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private decimal price;
        private Battery battery;
        

        
        public Laptop(string model, decimal price)  
        {
            this.Model = model;
            this.Price = price;
        }
        
        public Laptop(string model, Battery battery, string manufacturer, string processor,
                      string ram, string graphicsCard, string hdd, string screen, decimal price)  :this (model, price)
        {
            this.Battery = battery;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }
        
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new Exception("There is no such a model like this");
                }
                model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value) && value.Length < 2)
                {
                    throw new Exception("To short name of company");
                }
               manufacturer  = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value) && value.Length < 5)
                {
                    throw new ArgumentException("Incorrect Processor");
                }
                processor = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Incorrect information!");
                }
                ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new Exception("Incorrect graphics card !");
                }
                graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.Hdd; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException();
                }
                hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                screen = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!!");
                }
                price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {

                battery = value;
            }
        }


        public override string ToString()
        {

           string output = "Model: " + this.model + "\n";
            output += "Manufacturer: " + this.manufacturer + "\n";
            output += "Processor: " + this.processor + "\n";
            output += "RAM: " + this.ram + "\n";
            output += "Graphics card: " + this.graphicsCard + "\n";
            output += "HDD: " + this.hdd + "\n";
            output += "Screen: " + this.screen + "\n";
            output += /*"Battery"*/  this.battery + "\n";
            output += "Price: " + this.price + " lv.\n";


            return output;
        }
    }
}
