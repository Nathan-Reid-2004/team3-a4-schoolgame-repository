// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.ComponentModel;
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
        float playerPosY = 100;
        float playerPosX = 100;
        bool isMoving = false;
        Color playerColor = Color.Cyan;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(1280, 800);
            Window.SetTitle("Movement Shit");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            Movement();
            PlayerColour();
            if (isMoving == false)
            {
                playerColor=Color.Cyan;
            }
            else if (isMoving == true)
            {
                playerColor = Color.Yellow;
            }
            Draw.FillColor=(playerColor);
            Draw.Circle(playerPosX, playerPosY, 40);

            
        }
        public void Movement()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                playerPosY -= 6;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                playerPosY += 6;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                playerPosX -= 6;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                playerPosX += 6;
            }
        }
        public void PlayerColour()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                isMoving = true;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                isMoving = true;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                isMoving = true;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }
        }
    }

}
