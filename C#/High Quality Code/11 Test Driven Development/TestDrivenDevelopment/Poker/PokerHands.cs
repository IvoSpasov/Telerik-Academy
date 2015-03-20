namespace Poker
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public static class PokerHands
    {
        public static IHand StraightFlush
        {
            get
            {
                return new Hand(new List<ICard>()
                {
                    new Card(CardFace.Seven, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Clubs),
                    new Card(CardFace.Six, CardSuit.Clubs)
                });
            }
        }

        public static IHand FourOfAKind
        {
            get
            {
                return new Hand(new List<ICard>() 
                { 
                    new Card(CardFace.Ace, CardSuit.Clubs),                
                    new Card(CardFace.Ace, CardSuit.Diamonds),
                    new Card(CardFace.Ace, CardSuit.Hearts),
                    new Card(CardFace.Ace, CardSuit.Spades),
                    new Card(CardFace.King, CardSuit.Clubs),
                });
            }
        }

        public static IHand FullHouse
        {
            get
            {
                return new Hand(new List<ICard>()
                {
                    new Card(CardFace.Ten, CardSuit.Clubs),
                    new Card(CardFace.Ten, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Hearts)
                });
            }
        }

        public static IHand Flush
        {
            get
            {
                return new Hand(new List<ICard>() 
                { 
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.King, CardSuit.Clubs),
                    new Card(CardFace.Seven, CardSuit.Clubs),                
                    new Card(CardFace.Queen, CardSuit.Clubs),
                });
            }
        }

        public static IHand Straight
        {
            get
            {
                return new Hand(new List<ICard>()
                {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Six, CardSuit.Hearts)
                });
            }
        }

        public static IHand ThreeOfAKind
        {
            get
            {
                return new Hand(new List<ICard>()
                {
                    new Card(CardFace.Ten, CardSuit.Clubs),
                    new Card(CardFace.Ten, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Hearts)
                });
            }
        }

        public static IHand TwoPair
        {
            get
            {
                return new Hand(new List<ICard>()
                {
                    new Card(CardFace.Jack, CardSuit.Clubs),
                    new Card(CardFace.Jack, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Hearts)
                });
            }
        }

        public static IHand OnePair
        {
            get
            {
                return new Hand(new List<ICard>()
                {
                    new Card(CardFace.Nine, CardSuit.Clubs),
                    new Card(CardFace.Nine, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Spades),
                    new Card(CardFace.Jack, CardSuit.Spades),
                    new Card(CardFace.Two, CardSuit.Hearts)
                });
            }
        }

        public static IHand HighCard
        {
            get
            {
                return new Hand(new List<ICard>() 
                { 
                    new Card(CardFace.King, CardSuit.Hearts),                
                    new Card(CardFace.Jack, CardSuit.Hearts),
                    new Card(CardFace.Eight, CardSuit.Clubs),
                    new Card(CardFace.Seven, CardSuit.Diamonds),
                    new Card(CardFace.Four, CardSuit.Spades),
                });
            }
        }
    }
}
