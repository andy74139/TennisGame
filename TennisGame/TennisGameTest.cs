//using NUnit.Framework;
//using System;
//using System.Collections.Generic;

//namespace MyTennisGame
//{
//    [TestFixture]
//    public class TennisGameTest
//    {
//        private readonly Dictionary<int, string> _ScoreMapping = new Dictionary<int, string>()
//        {
//            {0, "Love"},
//            {1, "Fifteen"},
//            {2, "Thirty"},
//            {3, "Forty"}
//        };

//        private const string _PlayerName1 = "Lulu";
//        private const string _PlayerName2 = "Steve";

//        public string GetTennisResult(int score1, int score2)
//        {
//            if (score1 == score2)
//                return score1 >= 3 ? "Deuce" : $"{_ScoreMapping[score1]} All";

//            if (score1 <= 3 && score2 <= 3)
//                return $"{_ScoreMapping[score1]} {_ScoreMapping[score2]}";

//            var player = score1 > score2 ? _PlayerName1 : _PlayerName2;
//            var result = Math.Abs(score1 - score2) == 1 ? "Adv" : "Win";

//            var tennisResult = $"{player} {result}";
//            return tennisResult;
//        }

//        [TestCase(0, 0, ExpectedResult = "Love All")]
//        [TestCase(1, 0, ExpectedResult = "Fifteen Love")]
//        [TestCase(2, 0, ExpectedResult = "Thirty Love")]
//        [TestCase(3, 0, ExpectedResult = "Forty Love")]
//        [TestCase(0, 1, ExpectedResult = "Love Fifteen", TestName = "Yes")]
//        [TestCase(0, 2, ExpectedResult = "Love Thirty")]
//        [TestCase(0, 3, ExpectedResult = "Love Forty")]
//        [TestCase(1, 1, ExpectedResult = "Fifteen All")]
//        [TestCase(2, 2, ExpectedResult = "Thirty All")]
//        [TestCase(3, 3, ExpectedResult = "Deuce")]
//        [TestCase(4, 4, ExpectedResult = "Deuce")]
//        [TestCase(4, 3, ExpectedResult = "Lulu Adv")]
//        [TestCase(3, 4, ExpectedResult = "Steve Adv")]
//        [TestCase(5, 3, ExpectedResult = "Lulu Win")]
//        [TestCase(3, 5, ExpectedResult = "Steve Win")]
//        public string TennisGameTest1(int score1, int score2)
//        {
//            var actual = GetTennisResult(score1, score2);
//            return actual;
//        }
//    }
//}