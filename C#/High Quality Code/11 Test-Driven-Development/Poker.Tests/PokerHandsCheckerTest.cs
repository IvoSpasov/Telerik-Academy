namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        // Test the method IsValidHand()
        [TestMethod]
        public void TestIsValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
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
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
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
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
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
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),                
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestIsValidHandIfSameCards2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds),                
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        // Test the method IsFlush()
        [TestMethod]
        public void TestIsFlush1()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),                
                new Card(CardFace.Queen, CardSuit.Clubs),
            });
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsFlush2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),                
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsNotFlush1()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),                
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsNotFlush2()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsFlush(hand));
        }

        // Test the method IsFourOfAKind
        [TestMethod]
        public void TestIsFourOfAkind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestIsNotFourOfAkind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),                
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
            });
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }
    }
}
