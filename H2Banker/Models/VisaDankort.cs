using H2Banker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Models
{
    public class VisaDankort : ICard, IDebtCard, ICreditCard
    {
        //private string _ownerName;
        //private int _age;
        //private string _cardNumber;
        //private string _accountNumber;
        //private DateTime _expiryDate;
        //private int _withdrawLimitMonthly;
        //private bool _online;
        //private bool _abroad;
        //private double _accountBalance;
        //private double _withdrawTotal;
        //private double _credit;
        //private double _creditBalance;
        //private double _cashAdvanceTotal;
        //private double _cashAdvanceFee;
        //private int _gracePeriod;
        //private double _interestRate;
        public string OwnerName { get; set; } = "";
        public int Age { get; set; } = 18;
        public string CardNumber { get; set; } = "";
        public string AccountNumber { get; set; } = "";
        public ICard.CardType Type { get { return ICard.CardType.VisaDankort; } }
        public DateTime ExpiryDate { get; set; }
        public int WithdrawLimitMonthly { get; set; } = 25000;
        public bool Online { get; set; } = true;
        public bool Abroad { get; set; } = true;
        public double AccountBalance { get; set; } = 0;
        public double WithdrawTotal { get; set; } = 0;

        public int Credit { get; set; } = 20000;
        public int CreditBalance { get; set ; } = 0;
        public double CashAdvanceTotal { get; set  ; } = 0;
        public double CashAdvanceFee { get ; set  ; } = 0;
        public int GracePeriod { get ; set ; } = 0;
        public double InterestRate { get ; set; } = 0;

        public VisaDankort(string ownerName, string cardNumber, string accountNumber, DateTime expiryDate)
        {
            OwnerName = ownerName;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            ExpiryDate = expiryDate;
        }

        public override string ToString()
        {
            return $"\nVisa Dankort:\nCard Number: {CardNumber}\nOwner: {OwnerName}\nAccount Number: {AccountNumber}\nExpiry date: {ExpiryDate}\nCredit: {Credit}\n ";
        }
       
    }
}
