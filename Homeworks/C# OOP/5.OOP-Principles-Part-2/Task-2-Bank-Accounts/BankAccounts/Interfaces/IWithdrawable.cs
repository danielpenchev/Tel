namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface IWithdrawable
    {
        void WithDraw(decimal withDrawMoney);
    }
}
