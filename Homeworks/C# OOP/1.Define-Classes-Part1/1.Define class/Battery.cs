namespace _1.Define_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    public class Battery
    {
        private BatteryType model;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery(BatteryType model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }

        public Battery(BatteryType model, int hoursIdle, int hoursTalk) : this(model)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        
        public int? HoursIdle
        {
            get
            {
                return this.HoursIdle;
            }
            set
            {
                this.HoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(string.Format("Type - {0}", this.model));

            if (this.hoursIdle != null)
            {
                result.Append(string.Format("Hours idle - {0}", this.hoursIdle));
            }

            if (this.hoursTalk != null)
            {
                result.Append(string.Format("Hours talk - {0}", this, hoursIdle));
            }

            return result.ToString();
        }
    }
}
