using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class GSM 
    {
        private string brand;
        private string model;
        private decimal price;
        private Display display;
        private Battery battery;
        private CallHistory callHistory = new CallHistory();


        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public GSM(string brand,string model,decimal price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

        public GSM(string brand, string model, decimal price,Display display,Battery battery)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.display = display;
            this.battery = battery;
        }

        public void AddCallToCallHistory(Call call)
        {
            callHistory.AddCallToCallHistory(call);
        }

        public void RemoveFromCallHistory(Call call)
        {
            callHistory.RemoveFromCallHistory(call);
        }

        public void ClearCallHistory()
        {
            callHistory.ClearCallHistory();
        }

        public decimal CallPrice()
        {
            return callHistory.CallsPrice();
        }

        public int NumberOfCalls()
        {
            return callHistory.NumberOfCalls();
        }

        public int TotalMinutes()
        {
            return callHistory.TotalMinutes();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("GSM Brand:{0} Model:{1} Price:{2}",brand, model, price);
            Console.WriteLine("Display Model:{0} Size:{1} Colors:{2}", display.Model, display.Size, display.Colors);
            Console.WriteLine("Battery Model:{0} Size:{1}", battery.Model, battery.Capacity);
            Console.WriteLine("Total Calls:{0} Minutes:{2} Price: {1} лв. ",this.NumberOfCalls(), this.CallPrice(),this.TotalMinutes());
        }
    }
}
