using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTennisGame
{
    [TestClass]
    public class TennisGameTests1
    {
        private string _Score;
        private TennisGame _TennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            _Score = _TennisGame.Score();
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _TennisGame.FirstPlayerScore();
            _Score = _TennisGame.Score();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _TennisGame.FirstPlayerScore();
            _TennisGame.FirstPlayerScore();
            _Score = _TennisGame.Score();
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _TennisGame.FirstPlayerScore();
            _TennisGame.FirstPlayerScore();
            _TennisGame.FirstPlayerScore();
            _Score = _TennisGame.Score();
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _TennisGame.FirstPlayerScore();
            _TennisGame.FirstPlayerScore();
            _TennisGame.FirstPlayerScore();
            _Score = _TennisGame.Score();
            ScoreShouldBe("Forty Love");
        }
        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _Score);
        }
    }
}