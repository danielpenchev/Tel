namespace _1.Define_class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSM
    {
        #region Fields
        public static readonly GSM iPhone4S = new GSM("iPhone4s", "Apple", 300, "Cuklev", new Battery(BatteryType.LiIon, 12, 24));
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Display display;
        private Battery battery;
        private List<Call> callHistory = new List<Call>();

        #endregion

        #region Constructors

        public GSM(string model, string manufacturer, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
        }

        #endregion

        #region Properties

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentNullException("You must set model.");
                }
                this.model = value;
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
                if (value.Length <= 0)
                {
                    throw new ArgumentNullException("You muse set manufacturer.");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The price must be positive number.");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentNullException("You must set owner.");
                }
                this.owner = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
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
                this.battery = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        //public static GSM iPhone4S { get; set; }
        #endregion

        #region Methods

        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            var totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += this.callHistory[i].Duration;
            }

            decimal price = totalDuration * (pricePerMinute / 60);

            return price;
        }

        public string CallHistoryInfo()
        {
            var callHistoryInfo = new StringBuilder();
            if (this.callHistory.Count <= 0)
            {
                return "Call history is empty.";
            }

            callHistoryInfo.Append("Date\tTime\tDialed number\tCall duration\n");

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callHistoryInfo.Append(this.callHistory[i].ToString());
                callHistoryInfo.Append("\n");
            }

            return callHistoryInfo.ToString();
        }

        public void ShowInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("Model:\t\t {0}", this.model))
                .Append("\n")
                .Append(string.Format("Mannufacturer:\t {0}", this.manufacturer))
                .Append("\n");

            string value;

            value = string.Format("{0:f2} BGN", this.price);

            if (!string.IsNullOrEmpty(this.owner))
            {
                value = this.owner;
            }

            result.Append(string.Format("Owner\t\t {0}", value))
                .Append("\n");

            if (this.battery != null)
            {
                value = this.battery.ToString();
            }

            result.Append(string.Format("Battery:\t {0}", value))
                .Append("\n");

            if (this.display != null)
            {
                value = this.display.ToString();
            }

            result.Append(string.Format("Display:\t {0}", value))
                .Append("\n");


            return result.ToString();
        }

        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public void DeleteCall(Call currentCall)
        {
            this.callHistory.Remove(currentCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }
        #endregion
    }
}
