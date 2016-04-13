namespace BowlingScorer
{
    public class Game
    {
        private readonly int[] _rolls = new int[21];
        private int _index;

        public void AddRoll(int pins)
        {
            _rolls[_index++] = pins;
        }

        public int GetScore()
        {
            var score = 0;
            var rollIndex = 0;
            for(int frame = 1; frame <= 10; frame++)
            {
                //Stike
                if (_rolls[rollIndex] == 10)
                {
                    score += _rolls[rollIndex];
                    score += _rolls[rollIndex + 1];
                    score += _rolls[rollIndex + 2];
                    rollIndex += 1;
                }
                //Spare
                else if (_rolls[rollIndex] + _rolls[rollIndex + 1] == 10)
                {
                    score += _rolls[rollIndex];
                    score += _rolls[rollIndex + 1];
                    score += _rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                //Regular Case
                else
                {
                    score += _rolls[rollIndex];
                    score += _rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }
            return score;
        }
    }
}