using System.Security.Cryptography.X509Certificates;

namespace BowlingGame
{
    public class Game
    {
        private int score;
        private int knockedOverPins = 0;
        private int throwCount = 0;

        public void Roll(int pins)
        {
            throwCount++;

            if (knockedOverPins == 10)
            {
                knockedOverPins = 0;
                score += pins;         
            }
           
            knockedOverPins += pins;           

            if (throwCount == 2)
            {
                score += knockedOverPins;
                throwCount = 0;

                if (knockedOverPins < 10)
                {
                    knockedOverPins = 0;
                }
            }
        }

        public int Score()
        {
            return score;
        }
    }
}