using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Display testDisplay = new Display("iPhone Display", "5'5", "16 million");
            Battery testBattery = new Battery("iPhone Battery", "3000mAh", BatteryType.LiIon);         
            Call callOne = new Call(DateTime.Today, 420);
            Call callTwo = new Call(DateTime.Today, 366);

            GSM iPhone = new GSM("Apple", "Iphone 7", 499.99m, testDisplay, testBattery);
            iPhone.AddCallToCallHistory(callOne);
            iPhone.AddCallToCallHistory(callTwo);
            iPhone.DisplayInfo();
        }
    }
}
