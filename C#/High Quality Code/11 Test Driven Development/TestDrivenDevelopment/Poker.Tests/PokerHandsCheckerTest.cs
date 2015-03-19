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

        // Testing the method IsFlush()
        [TestMethod]
        public void TestIsFlushIfSameSuitNotInSequence()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),                
                new Card(CardFace.Queen, CardSuit.Clubs),
            });
            Assert.IsTrue(checker.IsFlush(hand));
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

        // Testing the method IsFourOfAKind
        [TestMethod]
        public void TestIsFourOfAKind()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsTrue(checker.IsFourOfAKind(hand));
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

        // Testing the method IsStraight
        [TestMethod]
        public void TestIsStraight()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts)
            });
            Assert.IsTrue(checker.IsStraight(hand));
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

        // Testing the method IsStraightFlush
        [TestMethod]
        public void TestIsStraightFlush()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
            });
            Assert.IsTrue(checker.IsStraightFlush(hand));
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

        // Testing the method IsFullHouse
        [TestMethod]
        public void TestIsFullHouse()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            });
            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestIsNotFullHouseWhenTwoPair()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        // Testing the method IsThreeOfAKind
        [TestMethod]
        public void TestIsThreeOfAKind()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts)
            });
            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestIsNotThreeOfAKindWhenFullHouse()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsThreeOfAKind(hand));
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
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            });
            Assert.IsTrue(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestIsNotTwoPairWhenFourOfAKind()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestIsNotTwoPairWhenOnePair()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsTwoPair(hand));
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
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts)
            });
            Assert.IsTrue(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestIsNotOnePairWhenTwoPair()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestIsNotOnePairWhenFullHouse()
        {
            var hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            });
            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestIsNotOnePairWhenFourOfAKind()
        {
            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsOnePair(hand));
        }
    }
}
