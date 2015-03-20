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

        // Testing the method IsValidHand(). This method is also tested in all the others.
        [TestMethod]
        public void TestIsValidHand()
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
        public void TestIsNotValidHandWhenLessCards()
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
        public void TestIsNotValidHandWhenMoreCards()
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
        public void TestIsNotValidHandWhenSameCards()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
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
        public void TestIsNotStraightFlushWhenOnlyStraight()
        {
            Assert.IsFalse(checker.IsStraightFlush(PokerHands.Straight));
        }

        [TestMethod]
        public void TestIsNotStraightFlushWhenOnlyFlush()
        {
            Assert.IsFalse(checker.IsStraightFlush(PokerHands.Flush));
        }

        // Testing the method IsFourOfAKind
        [TestMethod]
        public void TestIsFourOfAKind()
        {
            Assert.IsTrue(checker.IsFourOfAKind(PokerHands.FourOfAKind));
        }

        [TestMethod]
        public void TestIsNotFourOfAKindWhenFullHouse()
        {
            Assert.IsFalse(checker.IsFourOfAKind(PokerHands.FullHouse));
        }

        [TestMethod]
        public void TestIsNotFourOfAKindWhenTwoPair()
        {
            Assert.IsFalse(checker.IsFourOfAKind(PokerHands.TwoPair));
        }

        // Testing the method IsFullHouse
        [TestMethod]
        public void TestIsFullHouse()
        {
            Assert.IsTrue(checker.IsFullHouse(PokerHands.FullHouse));
        }

        [TestMethod]
        public void TestIsNotFullHouseWhenThreeOfAKind()
        {
            Assert.IsFalse(checker.IsFullHouse(PokerHands.ThreeOfAKind));
        }

        [TestMethod]
        public void TestIsNotFullHouseWhenTwoPair()
        {
            Assert.IsFalse(checker.IsFullHouse(PokerHands.TwoPair));
        }

        [TestMethod]
        public void TestIsNotFullHouseWhenOnePair()
        {
            Assert.IsFalse(checker.IsFullHouse(PokerHands.OnePair));
        }

        // Testing the method IsFlush()
        [TestMethod]
        public void TestIsFlush()
        {
            Assert.IsTrue(checker.IsFlush(PokerHands.Flush));
        }

        [TestMethod]
        public void TestIsNotFlushWhenSraight()
        {
            Assert.IsFalse(checker.IsFlush(PokerHands.Straight));
        }

        [TestMethod]
        public void TestIsNotFlushWhenStraightFlush()
        {
            Assert.IsFalse(checker.IsFlush(PokerHands.StraightFlush));
        }

        // Testing the method IsStraight
        [TestMethod]
        public void TestIsStraight()
        {
            Assert.IsTrue(checker.IsStraight(PokerHands.Straight));
        }

        [TestMethod]
        public void TestIsNotStraightWhenFlush()
        {
            Assert.IsFalse(checker.IsStraight(PokerHands.Flush));
        }

        [TestMethod]
        public void TestIsNotStraightWhenStraightFlush()
        {
            Assert.IsFalse(checker.IsStraight(PokerHands.StraightFlush));
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
        public void TestIsNotThreeOfAKindWhenTwoPair()
        {
            Assert.IsFalse(checker.IsThreeOfAKind(PokerHands.TwoPair));
        }

        [TestMethod]
        public void TestIsNotThreeOfAKindWhenOnePair()
        {
            Assert.IsFalse(checker.IsThreeOfAKind(PokerHands.OnePair));
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
        public void TestIsNotTwoPairWhenHighCard()
        {
            Assert.IsFalse(checker.IsTwoPair(PokerHands.HighCard));
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

        [TestMethod]
        public void TestIsNotOnePairWhenHighCard()
        {
            Assert.IsFalse(checker.IsOnePair(PokerHands.HighCard));
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
