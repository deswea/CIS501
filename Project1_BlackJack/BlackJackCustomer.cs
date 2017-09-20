using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_BlackJack
{
    class BlackJackCustomer : BJPlayer
    {

        public int NumWins
        {
            get; set;
        }

        public int NumLosses
        {
            get; set;
        }

        public int NumTimes
        {
            get; set;
        }

        BlackJackCustomer(decimal num, Deck deck)
        {
            : base(num);
            : base(deck);
        }
    }
}
