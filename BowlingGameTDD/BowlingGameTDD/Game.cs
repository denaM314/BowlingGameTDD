using System.Security.Cryptography.X509Certificates;

namespace BowlingGame
{
    public class Game
    {
        private int _gameScore;
        private int _frameScore = 0;
        private int _throwCount = 0;

        public void Roll(int pins)
        {
            _throwCount++;

            if (Strike())
            {
                _frameScore = 0;
                _gameScore += pins;         
            }
           
            _frameScore += pins;           

            if (_throwCount == 2)
            {
                _gameScore += _frameScore;
                _throwCount = 0;

                if (_frameScore < 10)
                {
                    _frameScore = 0;
                }
            }
        }

        private bool Strike()
        {
            return _throwCount == 1 && _frameScore == 10;
        }

        public int Score()
        {
            return _gameScore;
        }
    }
}