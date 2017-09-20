/*BJPlayer.cs
 * Author: Desmund Weathers*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_BlackJack
{
    /// <summary>
    /// The Blackjack Player Class
    /// </summary>
    public class BJPlayer
    {
        protected Card[] hand;
        Deck deck;
        private int topCardIndex;

        int HandValue
        {
            get; set;
        }

        decimal Money
        {
            get; set;
        }

        protected StringBuilder handString;
        int numAces;

        /// <summary>
        /// BJ Player Constructor
        /// </summary>
        /// <param name="startMoney"></param>
        /// <param name="deck"></param>
        BJPlayer(decimal startMoney, Deck deck)
        {
            Money = startMoney;
            hand = this.hand;
            topCardIndex = 
            HandValue =
            numAces =
            handString = 
        
            
        /// <summary>
        /// Draws one card from
        /// </summary>
        /// <param name="s"></param>
        /// <param name="faceUp"></param>
        public void Draw(string s, bool faceUp)
        {
            
        }

        /// <summary>
        /// Returns all the cards in hand to deck
        /// </summary>
        public void ReturnHandCardsToDeck()
        {

        }

        /// <summary>
        /// returns handString 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return handString;
        }




    }
}
