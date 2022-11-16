namespace CSE210_04.Game.Casting
{
    public class Collectable : Actor
    {
        private int _points;

        public Collectable(Game game, Vector2 position, string spriteName)
            : base(game, position, spriteName);

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