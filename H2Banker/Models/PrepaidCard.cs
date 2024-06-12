using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2Banker.Interfaces;

namespace H2Banker.Models
{
    public class PrepaidCard : ICard, IDebtCard
    {
        ////change to private 
        //protected string _ownerName;
        //protected int _age;
        //protected string _cardNumber;
        //protected string _accountNumber;
        //protected DateTime _expiryDate;
        //protected int _withdrawLimitMonthly;
        //protected bool _online;
        //protected bool _abroad;
        //protected double _accountBalance;
        //protected double _withdrawTotal;

        // protected properties, keep public if uses in other classes
        public string OwnerName { get; set; }
        public int Age { get; set; } = 0;
        public string CardNumber { get; set ; } 
        public string AccountNumber { get ; set ; } 
        public ICard.CardType Type { get { return ICard.CardType.PrepaidCard; } }
        public DateTime ExpiryDate { get ; set; }
        public int WithdrawLimitMonthly { get ; set ; } 
        public bool Online { get; set; } = false;
        public bool Abroad { get; set; } = false;
        public double AccountBalance { get ; set; } 
        public double WithdrawTotal { get ; set ; } 

        public PrepaidCard(string ownerName, string cardNumber, string accountNumber, DateTime expiryDate)
        {
            OwnerName = ownerName;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"\nPrepared Card:\nCard Number: {CardNumber}\nOwner: {OwnerName}\nAccount Number: {AccountNumber}\nExpiry date: {ExpiryDate}";
        }
    }
}
