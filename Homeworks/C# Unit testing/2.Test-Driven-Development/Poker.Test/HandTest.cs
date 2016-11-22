namespace Poker.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandThrowsExceptionWhenListOfCardsIsNull()
        {
            IList<ICard> cards = null;
            var hand = new Hand(cards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandShouldThrowExceptionWhenListOfCardsContainsNull()
        {
            IList<ICard> cards = new List<ICard>() { new Card(CardFace.Queen, CardSuit.Clubs), null };
            var hand = new Hand(cards);
        }

        [TestMethod]
        public void HandReturnsCorrectToString()
        {
            IList<ICard> cards = new List<ICard>() { new Card(CardFace.Ace, CardSuit.Clubs), new Card(CardFace.King, CardSuit.Clubs) };
            var hand = new Hand(cards);
            var expected = "Ace of Clubs | King of Clubs";

            Assert.AreEqual(expected, hand.ToString());
        }
    }
}