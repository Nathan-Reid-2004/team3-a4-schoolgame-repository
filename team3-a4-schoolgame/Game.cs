// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Security.Principal;
using MohawkGame2D;


// The namespace your code is in.


namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Mouse mouse;
        Cleaner cleaner;
        Apple apple;
        Paper paper;


        
       ///     Setup runs once before the game loop begins.
  





        /// </summary>
        public void Setup()
        {
            Window.SetTitle("untitled");
            Window.SetSize(800, 600);
            Window.ClearBackground(Color.OffWhite);



            mouse = new Mouse();
            cleaner = new Cleaner();
            apple = new Apple();
            paper = new Paper();

            mouse.Setup();
            cleaner.Setup();
            apple.Setup();
            paper.Setup();




        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()


        {
            cleaner.Update();
            apple.Update();
            mouse.Update();
            paper.Update();










        }
    }

}

              


