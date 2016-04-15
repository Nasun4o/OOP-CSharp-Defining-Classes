using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string batteryInfo;
        private double batteryLife;

        public Battery(string batteryInfo, double batteryLife)
        {
            this.BatteryInfo = batteryInfo;
            this.BatteryLife = batteryLife;
        }
        public string BatteryInfo
        {
            get
            {
                return this.batteryInfo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.batteryInfo = null;
                }
                batteryInfo = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new IndexOutOfRangeException("Battery life cannot be negative!!");
                }
                batteryLife = value;
            }
        }

        public override string ToString()
        {
            return "Battery: " + this.batteryInfo + "\nBattery Life: " + this.batteryLife;
        }


    }
}
