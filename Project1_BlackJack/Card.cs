using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_BlackJack
{
    public class Card
    {
        public enum CardSuit { Club, Diamond, Heart, Spade};

        public CardSuit Suit
        {
            get; set;
        }

        public int Rank
        {
            get; set;
        }

        public bool FaceUp
        {
            get;set;
        }

        public Card(int rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            if(FaceUp == false)
            {
                return "XX";
            }

            return 
        }
    }
}
