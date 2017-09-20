using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_BlackJack
{
    class Blackjack
    {
        Deck deck;

        /// <summary>
        /// Author Masaaki Mizuno
        /// </summary>
     void playoneGame()
        {
            bool bust;
            Console.WriteLine("==========New Game ===========");
            Console.WriteLine("You have: $" + BlackJackCustomer.Money);

            getUsersBet();
            deck.Shuffle();
            dealCards();

            if (testNatural21()) return;
            if (testSurrender()) return;
            customerTurn(out bust); if (bust) return;

            dealerTurn(out bust);
            determineWinner();
            
        }
        
        /// <summary>
        /// Author: Masaaki Mizuno
        /// </summary>
        public void go()
        {
            bool bankrupt;
            while (true)
            {
                playOneGame();

                BlackJackCustomer.ReturnHandToDeck();
                BJDealer.ReturnHandToDeck();

                displayStat(out bankrupt);
                if (bankrupt) break;

                if(!checkMoreGame()) break
            }
        }   
    }
}
