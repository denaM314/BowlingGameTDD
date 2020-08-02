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

        [Test]
        public void One_roll_increases_roll_by_number_of_fallen_pins()
        {
            game.Roll(7);
            Assert.AreEqual(game.Score(), 7);
        }
    }
}