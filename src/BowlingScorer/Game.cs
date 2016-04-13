namespace BowlingScorer
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _index;

        public void AddRoll(int pins)
        {
            _rolls[_index++] = pins;
        }

        public int GetScore()
        {
            var score = 0;
            for (var rollIndex = 0; rollIndex <= 20; rollIndex++)
            {
                score += _rolls[rollIndex];
            }
            return score;
        }
    }
}