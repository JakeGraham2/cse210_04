using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Greed.Game.Casting;
using Greed.Game.Directing;
using Greed.Game.Services;


namespace Greed
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLS = 60;
        private static int ROWS = 40;
        private static string CAPTION = "Miner Finds Gem (or not!?)";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_CollectableS = 40;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner
            // Actor banner = new Actor();
            // banner.SetText("");
            // banner.SetFontSize(FONT_SIZE);
            // banner.SetColor(WHITE);
            // banner.SetPosition(new Point(CELL_SIZE, 0));
            // cast.AddActor("banner", banner);

            // create the Miner
            Actor Miner = new Actor();
            Miner.SetText("#");
            Miner.SetFontSize(FONT_SIZE);
            Miner.SetColor(WHITE);
            Miner.SetPosition(new Point(MAX_X / 2, MAX_Y / 2));
            cast.AddActor("miner", Miner);

            // create the score
            Actor score = new Actor();
            score.SetText("Score: 0");
            score.SetFontSize(FONT_SIZE);
            score.SetColor(WHITE);
            score.SetPosition(new Point(0, MAX_Y - CELL_SIZE));
            cast.AddActor("score", score);

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}