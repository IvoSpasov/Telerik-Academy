namespace Poker
{
    using System;

    using Interfaces;

    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string face = GetFace();
            string suit = GetSuit();
            string card = face + suit;
            return card;
        }

        private string GetFace()
        {
            if ((int)this.Face <= 10)
            {
                return ((int)this.Face).ToString();
            }
            else
            {
                return this.Face.ToString()[0].ToString();
            }
        }

        private string GetSuit()
        {
            switch (this.Suit)
            {
                case CardSuit.Clubs: return "♣";
                case CardSuit.Diamonds: return "♦";
                case CardSuit.Hearts: return "♥";
                case CardSuit.Spades: return "♠";
                default: throw new ArgumentException("Invalid card suit");
            }
        }
    }
}

