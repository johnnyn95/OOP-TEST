using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Battery
    {
        private string model;
        private string capacity;
        private BatteryType type;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public Battery()
        {
            this.model = "Unknown";
            this.capacity = "Unknown";
            this.type = BatteryType.LiIon;
        }

        public Battery(string model, string capacity, BatteryType type)
        {
            this.model = model;
            this.capacity = capacity;
            this.type = type;
        }

        public void ChangeBatteryType(BatteryType type)
        {
            this.type = type;
        }
    }
}
