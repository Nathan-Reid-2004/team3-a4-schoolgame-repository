// Include the namespaces (code libraries) you need below.
using System;
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
        public float radius = 50.0f;
        public Vector2 position = new Vector2(40, 40);

        bool itemObtained = false;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(1280, 800);
            Window.ClearBackground(Color.Gray);
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.LineColor = Color.Black;
            Draw.Circle(position, radius);




            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {

                //first dialogue
                Text.Draw("Hey, great timing!\nClass is just about to start and I can't find my mouse anywhere!\nPlease help me find it!", 40, 650);
            } 

            //talking to teatcher after first dialogue

        }

        void ProcessInputs()
        {
            Vector2 mouseInsideCircle = Input.GetMousePosition() - position;
            bool insideCircle = mouseInsideCircle.Length() < radius;

            if (insideCircle && Input.IsMouseButtonPressed(MouseInput.Left))
            {
                itemObtained = true;
            }
        }
    }

}
