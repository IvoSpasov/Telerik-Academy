namespace Poker
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int ValidNumberOfCardsPerHand = 5;
        private const int Carre = 4;
        private const int ThreeMatchingCards = 3;
        private const int TwoMatchingCards = 2;
        private const int TwoPairsOfMatchingCards = 2;

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
            this.CheckForValidHand(hand);

            return this.AllCardsHaveSameSuit(hand) && this.AllCardsAreInSequence(hand);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            this.CheckForValidHand(hand);

            return this.AreCardsInHandOfSameFace(hand, Carre);
        }

        public bool IsFullHouse(IHand hand)
        {
            this.CheckForValidHand(hand);

            return this.AreCardsInHandOfSameFace(hand, ThreeMatchingCards) && this.AreCardsInHandOfSameFace(hand, TwoMatchingCards);
        }

        public bool IsFlush(IHand hand)
        {
            this.CheckForValidHand(hand);

            return this.AllCardsHaveSameSuit(hand) && (!this.AllCardsAreInSequence(hand));
        }

        public bool IsStraight(IHand hand)
        {
            this.CheckForValidHand(hand);

            return (!this.AllCardsHaveSameSuit(hand)) && this.AllCardsAreInSequence(hand);
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            this.CheckForValidHand(hand);

            return this.AreCardsInHandOfSameFace(hand, ThreeMatchingCards) && (!this.AreCardsInHandOfSameFace(hand, TwoMatchingCards));
        }

        public bool IsTwoPair(IHand hand)
        {
            this.CheckForValidHand(hand);

            var cardFacesCount = this.AddHandToDictionary(hand);
            int counter = 0;
            foreach (var cardFace in cardFacesCount)
            {
                if (cardFace.Value == TwoMatchingCards)
                {
                    counter++;
                }
            }

            return counter == TwoPairsOfMatchingCards;
        }

        public bool IsOnePair(IHand hand)
        {
            this.CheckForValidHand(hand);

            return this.AreCardsInHandOfSameFace(hand, TwoMatchingCards) && (!this.AreCardsInHandOfSameFace(hand, ThreeMatchingCards)) && (!this.IsTwoPair(hand));
        }

        public bool IsHighCard(IHand hand)
        {
            this.CheckForValidHand(hand);

            var cardsCount = this.AddHandToDictionary(hand);
            bool allCardsAreDifferent = cardsCount.Keys.Count == ValidNumberOfCardsPerHand;
            bool allCardsAreOfDifferentSuit = !this.AllCardsHaveSameSuit(hand);

            return allCardsAreDifferent && allCardsAreOfDifferentSuit && !this.IsStraight(hand);
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private void CheckForValidHand(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("The hand is not valid");
            }
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

        private bool AreCardsInHandOfSameFace(IHand hand, int numberOfCardsWithSameFace)
        {
            var cardFacesCount = this.AddHandToDictionary(hand);

            if (cardFacesCount.ContainsValue(numberOfCardsWithSameFace))
            {
                return true;
            }

            return false;
        }

        private Dictionary<CardFace, int> AddHandToDictionary(IHand hand)
        {
            var cardFacesCount = new Dictionary<CardFace, int>();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                CardFace currentFace = hand.Cards[i].Face;

                if (!cardFacesCount.ContainsKey(currentFace))
                {
                    cardFacesCount.Add(currentFace, 1);
                }
                else
                {
                    cardFacesCount[currentFace]++;
                }
            }

            return cardFacesCount;
        }
    }
}
