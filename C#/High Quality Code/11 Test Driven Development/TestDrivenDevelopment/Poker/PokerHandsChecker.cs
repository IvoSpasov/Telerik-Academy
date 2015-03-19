namespace Poker
{
    using System;

    using Interfaces;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int ValidNumberOfCardsPerHand = 5;
        private const int Carre = 4;

        public PokerHandsChecker()
        {
        }

        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != ValidNumberOfCardsPerHand)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Equals(hand.Cards[j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("The hand is not valid");
            }

            int counter = 1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        counter++;
                    }
                }

                if (counter == Carre)
                {
                    return true;
                }
                else
                {
                    counter = 0;
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("The hand is not valid");
            }

            return this.AllCardsHaveSameSuit(hand) && (!this.AllCardsAreInSequence(hand));
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("The hand is not valid");
            }

            return (!this.AllCardsHaveSameSuit(hand)) && this.AllCardsAreInSequence(hand);
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private bool AllCardsHaveSameSuit(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        private bool AllCardsAreInSequence(IHand hand)
        {
            int[] cardsValue = new int[ValidNumberOfCardsPerHand];
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                cardsValue[i] = (int)hand.Cards[i].Face;
            }

            bool inSequence = false;
            Array.Sort(cardsValue);
            for (int i = 0; i < cardsValue.Length - 1; i++)
            {
                if (cardsValue[i] + 1 == cardsValue[i + 1])
                {
                    inSequence = true;
                }
                else
                {
                    inSequence = false;
                    break;
                }
            }

            return inSequence;
        }
    }
}
