namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Customer cannot be null.");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative number.");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                { throw new ArgumentException("Interest rate cannot be negative number."); }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        public virtual decimal InterestAmount(int numberOfMonths)
        {
            decimal result = numberOfMonths * this.interestRate;

            return result;
        }
    }
}
