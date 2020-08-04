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
        public void Score_tracks_multiple_non_spare_rolls()
        {
            game.Roll(5);
            game.Roll(4);
            Assert.AreEqual(game.Score(), 9);
        }

        [Test]
        public void Score_increases_for_spare_by_10_plus_next_throw()
        {
            game.Roll(3);
            game.Roll(2);
            game.Roll(6);
            game.Roll(4);
            game.Roll(5);
            game.Roll(1);
            Assert.AreEqual(26, game.Score());
        }
    }
}