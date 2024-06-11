using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Interfaces
{
    public interface IDebtCard
    {
        double AccountBalance { get; set; }

        double WithdrawTotal { get; set; }
       
    }
}
