namespace _1.Define_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        public Call(DateTime dateTime, string phoneNumber, int callDuration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToLongTimeString();
            this.DialedPhone = phoneNumber;
            this.Duration = callDuration;
        }

        public string Date { get; private set; }

        public string DialedPhone { get; private set; }

        public int Duration { get; private set; }

        public string Time { get; private set; }

        public override string ToString()
        {
            var callInfo = string.Format("{0}\t{1}\t{2}\t{3}"
                , this.Date
                , this.Time
                , this.DialedPhone
                , this.Duration);
            return callInfo
;
        }
    }
}
