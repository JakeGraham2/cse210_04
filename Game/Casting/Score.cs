using System;
using Greed.Game.Casting;

namespace Greed.Game.Casting
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