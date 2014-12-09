namespace Poker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void TestHandToSting()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            Assert.AreEqual("A♣, A♦, K♥, K♠, 7♦", hand.ToString());
        }
    }
}
