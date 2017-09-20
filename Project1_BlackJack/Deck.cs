/*Deck.cs
 * Author: Desmund Weathers*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_BlackJack
{
    /// <summary>
    /// The deck class
    /// </summary>
    public class Deck
    {
        private Card[] deck = new Card[52];
        private int topCardIndex = 0;
        
        /// <summary>
        /// creation of the deck
        /// </summary>
        public Deck()
        {
            for(int i=0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    deck[i * 13 + j] = new Card(j, (Card.CardSuit)i);
                }
            }
            topCardIndex = 51;
        }


        Random rand = new Random();
        /// <summary>
        /// Method shuffles the deck of cards using the Knuth(Fisher-Yates) shuffle method.
        /// </summary>
        public void Shuffle()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                swap(i, rand.Next(0, deck.Length));
            }
          
    }
        /// <summary>
        /// swap method for shuffle
        /// </summary>
        /// <param name="a">int 1</param>
        /// <param name="b">int 2</param>
        private void swap(int a, int b)
        {
            Card temp = deck[b];
            deck[b] = deck[a];
            deck[a] = temp;
        }

        /// <summary>
        /// method draws card and removes it from the deck
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Card Draw(string s)
        {
            if(topCardIndex < 0)
            {
                throw new Exception("There are no cards left in the deck!");
            }
            Card drawnCard = deck[topCardIndex];
            deck[topCardIndex] = null;
            topCardIndex--;
            return drawnCard;

        }
        /// <summary>
        /// returns card to deck
        /// </summary>
        /// <param name="c">name of card</param>
        public void ReturnCard(Card c)
        {
            if(topCardIndex < 51)
            {
                topCardIndex++;
                deck[topCardIndex] = c;
            }
        }

    }
    
}
