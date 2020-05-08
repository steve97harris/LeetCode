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

            if (deck.Length <= 1)
                return deck;
            
            Array.Sort(deck);
            
            var newDeck = new Queue<int>();
            for (int i = deck.Length - 1; i >= 0; i--)
            {
                RevealCards(newDeck,deck[i]);
            }
            newDeck = new Queue<int>(newDeck.Reverse());

            foreach (var i in newDeck.ToArray())
            {
                Console.WriteLine(i);
            }
            return newDeck.ToArray();
        }

        private static void RevealCards(Queue<int> queue, int card)
        {
            if (queue.Count >= 2)
            {
                var topCard = queue.Dequeue();
                queue.Enqueue(topCard);
            }
            queue.Enqueue(card);
        }
    }
}