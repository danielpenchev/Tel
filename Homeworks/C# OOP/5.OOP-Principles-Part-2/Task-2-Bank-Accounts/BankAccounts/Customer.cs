namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        private CustomerType customerType;
        private string fullName;
        private string address;
        private string phoneNumber;

        public Customer(CustomerType customerType, string fullName, string address, string phoneNumber)
        {
            this.CustomerType = customerType;
            this.FullName = fullName;
            this.Address = address;
            this.phoneNumber = phoneNumber;
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set
            {
                this.customerType = value;
            }
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Full name required.");
                }
                else
                {
                    this.fullName = value;
                }
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Addres required.");
                }
                else
                {
                    this.address = value;
                }
            }
        }

        public string  PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Phone number required.");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
    }
}
