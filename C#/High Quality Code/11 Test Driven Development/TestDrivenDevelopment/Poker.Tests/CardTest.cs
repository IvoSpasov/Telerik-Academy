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
            Assert.AreEqual("A♣", testCard.ToString());
        }

        [TestMethod]
        public void TestCardToStringWithKingOfDiamonds()
        {
            var testCard = new Card(CardFace.King, CardSuit.Diamonds);
            Assert.AreEqual("K♦", testCard.ToString());
        }

        [TestMethod]
        public void TestCardToStringWithTenOfHearts()
        {
            var testCard = new Card(CardFace.Ten, CardSuit.Hearts);
            Assert.AreEqual("10♥", testCard.ToString());
        }

        [TestMethod]
        public void TestCardToStringWithTwoOfSpades()
        {
            var testCard = new Card(CardFace.Two, CardSuit.Spades);
            Assert.AreEqual("2♠", testCard.ToString());
        }
    }
}
