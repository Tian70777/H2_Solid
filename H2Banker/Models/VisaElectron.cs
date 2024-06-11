using H2Banker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Models
{
    internal class VisaElectron : Maestro
    {
        public ICard.CardType Type { get { return ICard.CardType.VisaElectron; } }
        public VisaElectron(string ownerName, string cardNumber, string accountNumber, DateTime expiryDate) :
            base(ownerName, cardNumber, accountNumber, expiryDate)
        {
            Age = 15;
            WithdrawLimitMonthly = 10000;
            OwnerName = ownerName;
        }
        public override string ToString()
        {
            return $"VisaElectron: {_cardNumber}, Owner: {OwnerName}, Account Number: {_accountNumber}, Expiry date: {_expiryDate}";
        }
    }
}
