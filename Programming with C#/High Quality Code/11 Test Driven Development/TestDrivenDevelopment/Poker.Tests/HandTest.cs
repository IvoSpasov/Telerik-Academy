namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;   

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void TestHandToSting()
        {
            var cards = new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);

            Assert.AreEqual("A♣, A♦, K♥, K♠, 7♦", hand.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestEmptyHandToString()
        {
            var cards = new List<ICard>();
            var hand = new Hand(cards);
            hand.ToString();
        }

        [TestMethod]
        public void TestAddCardToHand()
        {
            var hand = new Hand();
            var card = new Card(CardFace.Jack, CardSuit.Hearts);
            hand.AddCards(card);
            Assert.AreEqual("J♥", hand.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullCardToHand()
        {
            var hand = new Hand();
            Card card = null;
            hand.AddCards(card);
        }

        [TestMethod]
        public void TestAddCardsToHand()
        {
            var firstCards = new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts)
            };

            var secondCards = new List<ICard>()
            {                
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            };

            var hand = new Hand(firstCards);
            hand.AddCards(secondCards);
            Assert.AreEqual("A♣, A♦, K♥, K♠, 7♦", hand.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullListListOfCardsToHand()
        {
            var firstCards = new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts)
            };

            List<ICard> secondCards = null;

            var hand = new Hand(firstCards);
            hand.AddCards(secondCards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddEmptyListOfCardsToHand()
        {
            var firstCards = new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts)
            };

            var secondCards = new List<ICard>();

            var hand = new Hand(firstCards);
            hand.AddCards(secondCards);
        }
    }
}
