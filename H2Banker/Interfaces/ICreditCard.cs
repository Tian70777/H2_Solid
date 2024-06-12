using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Interfaces
{
    public interface ICreditCard
    {
        int Credit { get; set; }
        int CreditBalance { get; set; }
        double CashAdvanceTotal { get; set; }
        double CashAdvanceFee { get; set; }
        int GracePeriod { get; set; }
        double InterestRate { get; set; }


    }
}
