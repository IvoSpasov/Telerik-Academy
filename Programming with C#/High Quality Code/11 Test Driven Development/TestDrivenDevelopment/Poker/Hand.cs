namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;

    public class Hand : IHand
    {
        public Hand()
        {
            this.Cards = new List<ICard>();
        }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public void AddCards(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException("card", "The card cannot be null");
            }

            this.Cards.Add(card);
        }

        public void AddCards(IList<ICard> cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException("cards", "The cards list cannot be null");
            }

            if (cards.Count == 0)
            {
                throw new ArgumentException("The list of cards is empty");
            }

            this.Cards = this.Cards.Concat(cards).ToList();
        }

        public override string ToString()
        {
            if (this.Cards.Count == 0)
            {
                throw new InvalidOperationException("Cannot make a string from an empty list");
            }

            string result = string.Join(", ", this.Cards);
            return result;
        }
    }
}
