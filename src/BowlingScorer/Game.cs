namespace BowlingScorer
{
    public class Game
    {
        private int _score;
        private bool _isSecondRoll;
        private int _firstRollInFrame;
        private bool _hadSpare;

        public void AddRoll(int pins)
        {
            if (_isSecondRoll)
            {
                if (pins + _firstRollInFrame == 10)
                    _hadSpare = true;
                _firstRollInFrame = 0;
            }
            else
            {
                if (_hadSpare)
                {
                    _score += pins;
                    _hadSpare = false;
                }
                _firstRollInFrame = pins;
            }
            _score += pins;
            _isSecondRoll = !_isSecondRoll;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}