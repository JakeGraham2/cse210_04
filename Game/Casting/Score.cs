using System;
using Unit04.Game.Casting;

namespace CSE210_04.Game.Casting
{
    public class Score : Actor
    {   

        private int _points = 0;

        public Score()
        {
            
        }
        
        public void AddPoints(int points)
        {
            _points += points;
            SetText($"Score: {_points}");
        }



    }
}