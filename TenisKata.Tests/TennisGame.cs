﻿using System.Collections.Generic;

namespace TenisKata.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _score = new Dictionary<int, string>()
        {
            {2, "Thirdty" },
            {1, "Fifteen" },
            {3, "Forty" }
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == _secondPlayerScore)
            {
                if (_firstPlayerScore > 0)
                {
                    if (_firstPlayerScore == 3)
                    {
                        return "Deuce";
                    }
                    return _score[_firstPlayerScore] + " All";
                }
            }
            if (_secondPlayerScore > 0)
            {
                return "Love " + _score[_secondPlayerScore];
            }
            if (_firstPlayerScore > 0)
            {
                return _score[_firstPlayerScore] + " Love";
            }
            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScoreTime()
        {
            _secondPlayerScore++;
        }
    }
}