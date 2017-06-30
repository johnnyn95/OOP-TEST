using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Display
    {
        private string model;
        private string size;
        private string colors;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }


        public Display()
        {
            this.model = "Unknown";
            this.size = "Unknown";
            this.colors = "Unknown";
        }

        public Display(string model, string size, string colors)
        {
            this.model = model;
            this.size = size;
            this.colors = colors;
        }

    }
}
