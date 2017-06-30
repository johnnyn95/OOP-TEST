using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class CallHistory
    {
        private List<Call> callHistory = new List<Call>();
        private int totalDuration;

        public void AddCallToCallHistory(Call call)
        {
            callHistory.Add(call);
        }

        public void RemoveFromCallHistory(Call call)
        {
            callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            foreach (var call in callHistory)
            {
                callHistory.Remove(call);
            }
        }

        public int NumberOfCalls()
        {
            return callHistory.Count;
        }

        public decimal CallsPrice()
        {
            foreach (var call in callHistory)
            {
                 totalDuration += call.Duration;
            }

            return (totalDuration / 60) * 0.37m; 
        }

        public int TotalMinutes()
        {
            return totalDuration;
        }
    }
}
