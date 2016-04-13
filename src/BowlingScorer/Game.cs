namespace BowlingScorer
{
    public class Game
    {
        private int _score;

        public void AddRoll(int pins)
        {
            _score += pins;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}