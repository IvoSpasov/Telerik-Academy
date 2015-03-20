namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        private static PokerHandsChecker checker;

        [ClassInitialize]
        public static void InitializeChecker(TestContext context)
        {
            checker = new PokerHandsChecker();
        }

        // Testing the method IsValidHand()
        [TestMethod]
        public void TestIsValidHandIfOk()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestIsValidHandIfLessCards()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
            });
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestIsValidHandIfMoreCards()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestIsValidHandIfSameCards()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),                
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        // Testing the method IsStraightFlush
        [TestMethod]
        public void TestIsStraightFlush()
        {
            Assert.IsTrue(checker.IsStraightFlush(PokerHands.StraightFlush));
        }

        [TestMethod]
        public void TestIsNotStraightFlushByDifferentSuit()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
            });
            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestIsNotStraightFlushByNotInSequence()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
            });
            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        // Testing the method IsFourOfAKind
        [TestMethod]
        public void TestIsFourOfAKind()
        {
            Assert.IsTrue(checker.IsFourOfAKind(PokerHands.FourOfAKind));
        }

        [TestMethod]
        public void TestIsNotFourOfAKind()
        {
            IHand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        // Testing the method IsFullHouse
        [TestMethod]
        public void TestIsFullHouse()
        {
            Assert.IsTrue(checker.IsFullHouse(PokerHands.FullHouse));
        }

        [TestMethod]
        public void TestIsNotFullHouseWhenTwoPair()
        {
            Assert.IsFalse(checker.IsFullHouse(PokerHands.TwoPair));
        }

        // Testing the method IsFlush()
        [TestMethod]
        public void TestIsFlushIfSameSuitNotInSequence()
        {
            Assert.IsTrue(checker.IsFlush(PokerHands.Flush));
        }

        [TestMethod]
        public void TestIsNotFlushIfDifferentSuit()
        {
            IHand hand = new Hand(new List<ICard>()
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),                
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsNotFlushIfInSequence()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsFlush(hand));
        }

        // Testing the method IsStraight
        [TestMethod]
        public void TestIsStraight()
        {
            Assert.IsTrue(checker.IsStraight(PokerHands.Straight));
        }

        [TestMethod]
        public void TestIsNotStraight()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
            });
            Assert.IsFalse(checker.IsStraight(hand));
        }

        // Testing the method IsThreeOfAKind
        [TestMethod]
        public void TestIsThreeOfAKind()
        {
            Assert.IsTrue(checker.IsThreeOfAKind(PokerHands.ThreeOfAKind));
        }

        [TestMethod]
        public void TestIsNotThreeOfAKindWhenFullHouse()
        {
            Assert.IsFalse(checker.IsThreeOfAKind(PokerHands.FullHouse));
        }

        [TestMethod]
        public void TestIsNotThreeOfAKind()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        // Testing the method IsTwoPair
        [TestMethod]
        public void TestIsTwoPair()
        {
            Assert.IsTrue(checker.IsTwoPair(PokerHands.TwoPair));
        }

        [TestMethod]
        public void TestIsNotTwoPairWhenFourOfAKind()
        {
            Assert.IsFalse(checker.IsTwoPair(PokerHands.FourOfAKind));
        }

        [TestMethod]
        public void TestIsNotTwoPairWhenOnePair()
        {
            Assert.IsFalse(checker.IsTwoPair(PokerHands.OnePair));
        }

        [TestMethod]
        public void TestIsNotTwoPair()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        // Testing method IsOnePair
        [TestMethod]
        public void TestIsOnePair()
        {
            Assert.IsTrue(checker.IsOnePair(PokerHands.OnePair));
        }

        [TestMethod]
        public void TestIsNotOnePairWhenTwoPair()
        {
            Assert.IsFalse(checker.IsOnePair(PokerHands.TwoPair));
        }

        [TestMethod]
        public void TestIsNotOnePairWhenFullHouse()
        {
            Assert.IsFalse(checker.IsOnePair(PokerHands.FullHouse));
        }

        [TestMethod]
        public void TestIsNotOnePairWhenFourOfAKind()
        {
            Assert.IsFalse(checker.IsOnePair(PokerHands.FourOfAKind));
        }

        // Testing the method IsHighCard
        [TestMethod]
        public void TestIsHighCard()
        {
            Assert.IsTrue(checker.IsHighCard(PokerHands.HighCard));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenStraightFlush()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.StraightFlush));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenFourOfAKind()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.FourOfAKind));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenFullHouse()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.FullHouse));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenStraight()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.Straight));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenFlush()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.Flush));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenThreeOfAKind()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.ThreeOfAKind));
        }

        [TestMethod]
        public void TestNotHighCardWhenTwoPair()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.TwoPair));
        }

        [TestMethod]
        public void TestIsNotHighCardWhenOnePair()
        {
            Assert.IsFalse(checker.IsHighCard(PokerHands.OnePair));
        }
    }
}
