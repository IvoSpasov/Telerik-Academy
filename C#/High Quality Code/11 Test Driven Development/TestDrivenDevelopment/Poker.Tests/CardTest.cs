namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void TestCardToStringWithAceOfClubs()
        {
            var testCard = new Card(CardFace.Ace, CardSuit.Clubs);
            Assert.AreEqual(testCard.ToString(), "A♣"); // change
        }

        [TestMethod]
        public void TestCardToStringWithKingOfDiamonds()
        {
            var testCard = new Card(CardFace.King, CardSuit.Diamonds);
            Assert.AreEqual(testCard.ToString(), "K♦");
        }

        [TestMethod]
        public void TestCardToStringWithTenOfHearts()
        {
            var testCard = new Card(CardFace.Ten, CardSuit.Hearts);
            Assert.AreEqual(testCard.ToString(), "10♥");
        }

        [TestMethod]
        public void TestCardToStringWithTwoOfSpades()
        {
            var testCard = new Card(CardFace.Two, CardSuit.Spades);
            Assert.AreEqual(testCard.ToString(), "2♠");
        }
    }
}
