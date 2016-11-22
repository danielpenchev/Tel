﻿namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Deposit(decimal depositMoney)
        {
            if(depositMoney <= 0M)
            {
                throw new ArgumentException("Deposit money cannot be negative or zero!");
            }
            else
            {
                this.Balance += depositMoney;
            }
        }

        public override decimal InterestAmount(int numberOfMonths)
        {
            if (Customer.CustomerType == CustomerType.Companies)
            {
                if(numberOfMonths <= 12 && numberOfMonths >= 0)
                {
                    return (decimal)(base.InterestRate / 2) * numberOfMonths;
                }
                else if (numberOfMonths > 12)
                {
                    return base.InterestRate * numberOfMonths;
                }
                else
                {
                    throw new ArgumentException("Number of months cannot be negative or zero!");
                }
            }
            else if(Customer.CustomerType == CustomerType.Individuals)
            {
                if(numberOfMonths <= 6 && numberOfMonths >= 0)
                {
                    return 0;
                }
                else if(numberOfMonths > 6)
                {
                    return base.InterestRate * numberOfMonths;
                }
                else
                {
                    throw new ArgumentException("Number of months cannot be negative or zero!");
                }
            }
            else
            {
                throw new ArgumentException("Incorrect customer type!");
            }
        }
    }
}
