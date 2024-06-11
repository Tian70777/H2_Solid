using H2Banker.Controllers;
using H2Banker.Interfaces;
using H2Banker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Services
{
    public class CardService
    {
        private BankController _bank;
        // inject _myBank
        public CardService(BankController bank)
        {
            _bank = bank;
        }

        public ICard CreatePrepaidCard(Owner owner)
        {
            // generate card number
            string cardNr = GeneratePrepaidCardNumber();
            
            // generate account number
            string accountNr = GenerateAccountNumber();

            // generate expiry date
            DateTime expiryDate = DateTime.Now.AddYears(20);
            
            ICard card = new PrepaidCard(owner.Name, cardNr, accountNr, expiryDate);

            // add card to owner and bank
            owner.MyCards.Add(card);
            _bank.Cards.Add(card);

            return card;
        }
        private string GeneratePrepaidCardNumber()
        {
            Random random = new Random();
            string cardNumber;

            // check if card number already exists
            do
            {
                cardNumber = "2400";
                for (int i = 0; i < 12; i++)
                {
                    cardNumber += random.Next(0, 10);
                }
            }
            while (_bank.Cards.Any(card => card.CardNumber == cardNumber));
            
            return cardNumber;
        }
        
        public ICard CreateMaestroCard(Owner owner)
        {
            // checked age
            int age = GetOwnerAge(owner);
            if ( age < 18)
            {
                throw new Exception("Owner must be at least 18 years old to create a Maestro Card.");
            }

            // generate card number
            string cardNr = GenerateMaestroNumber();

            // generate account number
            string accountNr = GenerateAccountNumber();

            // generate expiry date
            DateTime expiryDate = DateTime.Now.AddYears(5).AddMonths(8);

            ICard card = new Maestro(owner.Name, cardNr, accountNr, expiryDate);

            // add card to owner and bank
            owner.MyCards.Add(card);
            _bank.Cards.Add(card);

            return card;
        }
        private string GenerateMaestroNumber()
        {
            Random random = new Random();
            string cardNumber;

            // check if card number already exists
            do
            {
                List<string> maestroList = new List<string> { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
                cardNumber = maestroList[random.Next(0, 9)];

                for (int i = 0; i < 15; i++)
                {
                    cardNumber += random.Next(0, 10);
                }
            }
            while (_bank.Cards.Any(card => card.CardNumber == cardNumber));

            return cardNumber;
        }

        public ICard CreateVisaElectronCard(Owner owner)
        {
            // checked age
            int age = GetOwnerAge(owner);
            if (age < 15)
            {
                throw new Exception("Owner must be at least 15 years old to create a Visa Electron Card.");
            }

            // generate card number
            string cardNr = GenerateVisaElectronNumber();

            // generate account number
            string accountNr = GenerateAccountNumber();

            // generate expiry date
            DateTime expiryDate = DateTime.Now.AddYears(5).AddMonths(8);

            ICard card = new VisaElectron(owner.Name, cardNr, accountNr, expiryDate);

            // add card to owner and bank
            owner.MyCards.Add(card);
            _bank.Cards.Add(card);

            return card;
        }

        private string GenerateVisaElectronNumber()
        {
            Random random = new Random();
            string cardNumber;

            // check if card number already exists
            do
            {
                List<string> visaElectronList = new List<string> { "4026", "417500", "4508", "4844", "4913", "4917" };
                cardNumber = visaElectronList[random.Next(0, 6)];

                // Iterate times for generating rest of the card number
                int iterateNumber = 0;

                // check digits in card number
                if(cardNumber == "417500")
                {
                    iterateNumber = 10;
                }
                else
                {
                    iterateNumber = 12;
                }

                // generate card number
                for (int i = 0; i < iterateNumber; i++)
                {
                    cardNumber += random.Next(0, 10);
                }
            }
            while (_bank.Cards.Any(card => card.CardNumber == cardNumber));

            return cardNumber;
        }


        public ICard CreateVisaDankort(Owner owner)
        {
            // checked age
            int age = GetOwnerAge(owner);
            if (age < 18)
            {
                throw new Exception("Owner must be at least 18 years old to create a Visa Dankort.");
            }

            // generate card number
            string cardNr = GenerateVisaDankortNumber();

            // generate account number
            string accountNr = GenerateAccountNumber();

            // generate expiry date
            DateTime expiryDate = DateTime.Now.AddYears(5);

            ICard card = new VisaDankort(owner.Name, cardNr, accountNr, expiryDate);

            // add card to owner and bank
            owner.MyCards.Add(card);
            _bank.Cards.Add(card);

            return card;
        }

        private string GenerateVisaDankortNumber()
        {
            Random random = new Random();
            string cardNumber;

            // check if card number already exists
            do
            {
                cardNumber = "4";

                for (int i = 0; i < 15; i++)
                {
                    cardNumber += random.Next(0, 10);
                }
            }
            while (_bank.Cards.Any(card => card.CardNumber == cardNumber));

            return cardNumber;
        }


        public ICard CreateMastercard(Owner owner)
        {
            // checked age
            int age = GetOwnerAge(owner);
            if (age < 18)
            {
                throw new Exception("Owner must be at least 18 years old to create a MasterCard.");
            }

            // generate card number
            string cardNr = GenerateMastercardNumber();

            // generate account number
            string accountNr = GenerateAccountNumber();

            // generate expiry date
            DateTime expiryDate = DateTime.Now.AddYears(5);

            ICard card = new MasterCard(owner.Name, cardNr, accountNr, expiryDate);

            // add card to owner and bank
            owner.MyCards.Add(card);
            _bank.Cards.Add(card);

            return card;
        }

        private string GenerateMastercardNumber()
        {
            Random random = new Random();
            string cardNumber;

            // check if card number already exists
            do
            {
                List<string> MastercardList = new List<string> { "51", "52", "53", "54", "55" };
                cardNumber = MastercardList[random.Next(0, 5)];

                for (int i = 0; i < 14; i++)
                {
                    cardNumber += random.Next(0, 10);
                }
            }
            while (_bank.Cards.Any(card => card.CardNumber == cardNumber));

            return cardNumber;
        }

        private int GetOwnerAge(Owner owner)
        {
            int age = DateTime.Now.Year - owner.Birthday.Year;
            // check if birthday has passed this year
            if (DateTime.Now.Month < owner.Birthday.Month || (DateTime.Now.Month == owner.Birthday.Month && DateTime.Now.Day < owner.Birthday.Day))
            {
                age--;
            }
            
            return age;
        }

        private string GenerateAccountNumber()
        {
            Random random = new Random();
            string accountNumber;

            // check if account number already exists
            do
            {
                accountNumber = "3520";
                for (int i = 0; i < 10; i++)
                {
                    accountNumber += random.Next(0, 10);
                }
            }
            while (_bank.Cards.Any(card => card.AccountNumber == accountNumber));
            
            return accountNumber;
        }

        //public double CashAdvance(double amount)
        //{
        //    return _creditBalance -= amount;
        //}

        //public double Deposit(double amount)
        //{
        //    return _accountBalance += amount;
        //}

        //public double Pay(double amount)
        //{
        //    return _accountBalance -= amount;
        //}

        //public double Withdraw(double amount)
        //{
        //    return _accountBalance -= amount;
        //}

    }
}
