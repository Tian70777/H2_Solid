using H2Banker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Models
{
    internal class Maestro : PrepaidCard
    {
        public ICard.CardType Type { get { return ICard.CardType.Maestro; } }
        public Maestro(string ownerName, string cardNumber, string accountNumber, DateTime expiryDate) : 
            base(ownerName, cardNumber, accountNumber, expiryDate)
        {
            OwnerName = ownerName;
            Online = true;
            Abroad = true;
            Age = 18;
        }
        public override string ToString()
        {
            return $"Maestro Card: {_cardNumber}, Owner: {OwnerName}, Account Number: {_accountNumber}, Expiry date: {_expiryDate}";
        }
    }
}
