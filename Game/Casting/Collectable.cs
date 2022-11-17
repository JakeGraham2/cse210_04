using System;
using Greed.Game.Casting;

namespace Greed.Game.Casting
{
    public class Collectable : Actor
    {
        private int _points;

        public Collectable()
        {

        }
        

        public int GetPoints()
        {
            return _points;
        }

        public void SetPoints(int points)
        {
            _points = points;
        }



    }
}