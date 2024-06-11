using H2Banker.Interfaces;
using H2Banker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Banker.Controllers
{
    public class BankController
    {
        private List<Owner> _owners;
        private List<ICard> _cards;
        public List<Owner> Owners { get; set; }
        public List<ICard> Cards { get; set; }

        public BankController()
        {
            Owners = new List<Owner>();
            Cards = new List<ICard>();
        }
    }
}
