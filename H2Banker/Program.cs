

using H2Banker.Controllers;
using H2Banker.Interfaces;
using H2Banker.Models;
using H2Banker.Services;

BankController bank = new BankController();

// Create a new owner
Owner owner1 = new Owner("John Doe", "Main Street 1", "12345678", new DateTime(1990, 1, 1));

// Add owner to oners list
bank.Owners.Add(owner1);

// Create new cardService
CardService cardService = new CardService(bank);

// Create a new prepaid card for the owner
ICard newCard1 = cardService.CreatePrepaidCard(owner1);
ICard newCard2 = cardService.CreateMastercard(owner1);
ICard newCard3 = cardService.CreateMaestroCard(owner1);
ICard newCard4 = cardService.CreateVisaDankort(owner1);
ICard newCard5 = cardService.CreateVisaElectronCard(owner1);

Console.WriteLine(newCard1.ToString());
Console.WriteLine(newCard2.ToString());
Console.WriteLine(newCard3.ToString());
Console.WriteLine(newCard4.ToString());
Console.WriteLine(newCard5.ToString());

//print all cards in bank:
foreach (var card in bank.Cards)
{
    Console.WriteLine(card.OwnerName);
    Console.WriteLine(card.CardNumber);
}



Console.ReadLine();
