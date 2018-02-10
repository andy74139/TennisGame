using System.Collections.Generic;

namespace MyTennisGame
{
    public class TennisGame
    {
        private int _FirstPlayerScore;

        private Dictionary<int, string> _ScoreMapping = new Dictionary<int, string>
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public string Score()
        {
            if (_FirstPlayerScore > 0)
            {
                return _ScoreMapping[_FirstPlayerScore] + " Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _FirstPlayerScore++;
        }
    }
}