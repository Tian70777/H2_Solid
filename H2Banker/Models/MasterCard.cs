using H2Banker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Models
{
    public class MasterCard : ICard, ICreditCard
    {
        private string _ownerName;
        private int _age;
        private string _cardNumber;
        private string _accountNumber;
        private DateTime _expiryDate;
        private int _withdrawLimitMonthly;
        private int _withdrawLimitDaily;
        private bool _online;
        private bool _abroad;
        private double _credit;
        private double _creditBalance;
        private double _cashAdvanceTotal;
        private double _cashAdvanceFee;
        private int _gracePeriod;
        private double _interestRate;
        public string OwnerName { get; set; }
        public int Age { get; set; } = 18;
        public string CardNumber { get; set; } 
        public string AccountNumber { get; set; } 
        public ICard.CardType Type { get { return ICard.CardType.MasterCard; } }
        public DateTime ExpiryDate { get; set; }
        public int WithdrawLimitMonthly { get; set; } = 30000;
        public int WithdrawLimitDaily { get; set; } = 5000;
        public bool Online { get; set; } = true;
        public bool Abroad { get; set; } = true;

        public int Credit { get; set; } = 40000;
        public int CreditBalance { get; set; } = 0;
        public double CashAdvanceTotal { get; set; } = 0;
        public double CashAdvanceFee { get; set; } = 0;
        public int GracePeriod { get; set; } = 0;
        public double InterestRate { get; set; } = 0;

        public MasterCard(string ownerName, string cardNumber, string accountNumber, DateTime expiryDate)
        {
            _ownerName = ownerName;
            _cardNumber = cardNumber;
            _accountNumber = accountNumber;
            _expiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"MasterCard: {_cardNumber}, Owner: {_ownerName}, Account Number: {_accountNumber}, Expiry date: {_expiryDate}, Credit :{Credit}";
        }
    }
}
