using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2Banker.Interfaces;

namespace H2Banker.Models
{
    public class Owner
    {
        //private string _name;
        //private string _address;
        //private string _phoneNumber;
        //private DateTime _birthday;
        //private List<ICard> _myCards;
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public List<ICard> MyCards { get; set; }
       
        public Owner(string name, string address, string phoneNumber, DateTime birthday)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            MyCards = new List<ICard>();
        }
    }
}
