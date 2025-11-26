// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Desks drawDesks;

        Walls drawWalls;

        Interactables drawInteractables;



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(1280, 800);
            Window.SetTitle("Collision Test");
            Window.TargetFPS = 60;

            drawDesks = new Desks();

            drawWalls = new Walls();

            drawInteractables = new Interactables();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            drawDesks.Update();
            drawWalls.Update();
            drawInteractables.Update();
            
        }

}

}
