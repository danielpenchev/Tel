namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class BankAccRun
    {
        static void Print(Account[] account)
        {
            foreach (var element in account)
            {
                Console.WriteLine("Type: " + element.Customer.CustomerType);
                Console.WriteLine("Name: " + element.Customer.FullName);
                Console.WriteLine("Address: " + element.Customer.Address);
                Console.WriteLine("Phone number: " + element.Customer.PhoneNumber);
                Console.WriteLine("Interest amount: " + element.InterestAmount(9));
            }
        }
        public static void Testing()
        {
            Account[] depositAccount = new Account[]
            {
                new DepositAccount(new Customer(CustomerType.Individuals, "Krisko Kriskov", "Yambooool", "0888111222"), 100M, 2M),
                new DepositAccount(new Customer(CustomerType.Companies, "Slunchaka AD", "Nesebar area", "052111111"), 150M, 3M),
                new DepositAccount(new Customer(CustomerType.Companies, "ET Barca", "Barcelona", "01111111"), 100000M, 5M)
            };

            Account[] loanAccont = new Account[]
            {
                new LoanAccount(new Customer(CustomerType.Companies, "Lukoil Bulgaria", "Sofia", "02/55555"), 200M, 3M),
                new LoanAccount(new Customer(CustomerType.Individuals, "Gechito ot London", "London", "033-12-3"), 1000M, 2M),
                new LoanAccount(new Customer(CustomerType.Individuals, "Dimcho ot Varna", "Varna", "052-22-4"), 155M, 11M)
            };
            
            Account[] mortgageAccount = new Account[]
            {
                new MortgageAccount(new Customer(CustomerType.Individuals, "Svetlin Nakov", "Veliko Tarnovo", "011-11-11"), 1500M, 10M),
                new MortgageAccount(new Customer(CustomerType.Individuals, "Dota RULLZ", "IceFrog", "08855123"), 444M , 2M),
                new MortgageAccount(new Customer(CustomerType.Companies, "Globul", "Sofia", "022-23-3"), 222M , 2M)
            };
            
            Console.WriteLine("---------- Deposit accounts ----------");
            Print(depositAccount);

            Console.WriteLine("---------- Loan accounts ----------");
            Print(loanAccont);

            Console.WriteLine("---------- Mortgage accounts ----------");
            Print(mortgageAccount);
            
            Console.WriteLine("---------- Leonardo deposit accounts ----------");
            DepositAccount leonardoDepositeAccount = new DepositAccount(new Customer(CustomerType.Individuals, "Leonardo DiCaprio", "Pleven", "044-2222-2"), 500M, 12M);
            leonardoDepositeAccount.Deposit(111M);
            leonardoDepositeAccount.WithDraw(11M);
            Console.WriteLine("Leonardo balance: " + leonardoDepositeAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- Apple loan accounts ----------");
            LoanAccount appleLoanAccount = new LoanAccount(new Customer(CustomerType.Companies, "Apple", "USA", "000111"), 199900M, 14M);
            appleLoanAccount.Deposit(1313M);
            Console.WriteLine("Apple balande: " + appleLoanAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- Lenovo mortgage accounts ----------");
            MortgageAccount lenovoMortgageAccount = new MortgageAccount(new Customer(CustomerType.Companies, "LENOVO", "China", "01230123"), 88888M, 100M);
            lenovoMortgageAccount.Deposit(10000M);
            Console.WriteLine("Lenovo balance: " + lenovoMortgageAccount.Balance);
            Console.WriteLine();
        }
    }
}
