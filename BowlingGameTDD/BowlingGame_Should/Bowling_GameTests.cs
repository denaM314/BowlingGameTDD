using NUnit.Framework;
using BowlingGame;

namespace BowlingGame_Should
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Gutterball_does_not_increase_score()
        {
            var game = new Game();
            game.Roll(0);
            Assert.AreEqual(game.Score(), 0);
        }
    }
}