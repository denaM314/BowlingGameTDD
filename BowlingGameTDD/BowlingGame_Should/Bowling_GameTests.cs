using NUnit.Framework;
using BowlingGame;

namespace BowlingGame_Should
{
    public class Tests
    {
        private Game game;
        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Gutterball_does_not_increase_score()
        {
            game.Roll(0);
            Assert.AreEqual(game.Score(), 0);
        }
    }
}