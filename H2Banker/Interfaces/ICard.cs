using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Interfaces
{
    public interface ICard
    {
        public string OwnerName { get; set; } 
        int Age { get; set; }
        string CardNumber { get; set; }
        string AccountNumber { get; set; }
        CardType Type { get; }
        DateTime ExpiryDate { get; set; }
        int WithdrawLimitMonthly { get; set; }
        bool Online { get; set; }
        bool Abroad { get; set; }

      

        enum CardType
        {
            PrepaidCard,
            VisaElectron,
            Maestro,
            VisaDankort,
            MasterCard,
        }
    }
}
