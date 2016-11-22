namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Deposit(decimal depositMoney)
        {
            if(depositMoney <= 0)
            {
                throw new ArgumentException("Deposit money cannot be negative or zero!");
            }
            else
            {
                this.Balance += depositMoney;
            }
        }

        public void WithDraw(decimal withDrawMoney)
        {
            if(withDrawMoney <= 0)
            {
                throw new ArgumentException("Withdraw money cannot be negative or zero!");
            }
            else if(this.Balance <= withDrawMoney)
            {
                throw new ArgumentException("Cannot withdraw more money than have in balance!");
            }
            else
            {
                this.Balance -= withDrawMoney;
            }
        }

        public override decimal InterestAmount(int numberOfMonths)
        {
            if(base.Balance >= 0 && base.Balance <= 1000)
            {
                return 0;
            }
            else if (base.Balance > 1000)
            {
                return numberOfMonths * base.InterestRate;
            }
            else
            {
                throw new ArgumentException("Balance cannot be negative!");
            }
        }
    }
}
