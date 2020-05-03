using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LeetCode.Main.Solutions
{
    public static class RevealCardsInIncreasingOrder
    {
        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            /*  1; Take the top card of the deck, reveal it, and take it out of the deck.
                2; If there are still cards in the deck, put the next top card of the deck at the bottom of the deck.
                3; If there are still unrevealed cards, go back to step 1.  Otherwise, stop.
                4; Return an ordering of the deck that would reveal the cards in increasing order. */
            
            
            var sortedDeck = deck.ToList();
            sortedDeck.Sort();

            var j = 0;
            deck[0] = sortedDeck[0];
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = 0;
                if (i % 2 == 0)
                {
                    deck[i] = sortedDeck[j];       
                    j++;
                }
            }

            sortedDeck.RemoveRange(0,j);

            for (int i = 0; i < deck.Length; i++)
            {
                if (deck[deck.Length-1] != 0)
                {
                    if (i % 2 != 0)
                    {
                        // deck[i] = ;
                    }
                }
            }

            for (int i = 0; i < deck.Length; i++)
            {
                // Console.WriteLine(deck[i]);
            }
            
            // var deckQueue = new Queue<int>();
            // for (int i = 0; i < deck.Length; i++)
            // {
            //     deckQueue.Enqueue(deck[i]);
            // }
            
            // RevealCards(deckQueue);

            

            
            return deck;
        }

        private static void RevealCards(Queue<int> queue)
        {
            queue.Dequeue();     // removes and returns object at beginning of queue (reveal and remove from deck)
            if (queue.Count > 0)
            {
                var topCard = queue.Dequeue();    // removes and returns again if count > 0
                queue.Enqueue(topCard);    // place top card at end of queue
            }
            if (queue.Count > 0)
                RevealCards(queue);
            return;
        }
    }
}