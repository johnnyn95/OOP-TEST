using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Call 
    {
        private DateTime dateTime;
        private int duration;

        public int Duration { get { return this.duration; } set { } }

        public Call(DateTime dateTime,int duration)
        {
            this.dateTime = dateTime;
            this.duration = duration;
        }
    }
}
