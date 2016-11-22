namespace Poker.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardShouldCompareCardsCorrectly_EqualCard()
        {
            var firstCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            var secondCard = new Card(CardFace.Ace, CardSuit.Diamonds);

            Assert.IsTrue(firstCard.Equals(secondCard));
        }

        [TestMethod]
        public void CardShouldCompareCardsCorrectly_DifferentCards()
        {
            var firstCard = new Card(CardFace.Ace, CardSuit.Spades);
            var secondCard = new Card(CardFace.King, CardSuit.Spades);

            Assert.IsFalse(firstCard.Equals(secondCard));
        }

        [TestMethod]
        public void CardShouldReturnToStringCorrectly()
        {
            var card = new Card(CardFace.Ace, CardSuit.Spades);
            var expected = "Ace of Spades";

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
