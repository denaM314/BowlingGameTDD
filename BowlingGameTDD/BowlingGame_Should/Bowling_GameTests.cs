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

        [Test]
        public void Score_tracks_multiple_non_spare_rolls()
        {
            game.Roll(5);
            game.Roll(4);
            Assert.AreEqual(game.Score(), 9);
        }
    }
}