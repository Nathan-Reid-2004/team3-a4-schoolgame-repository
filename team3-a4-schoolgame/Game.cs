// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
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
        float playerPosY = 100;
        float playerPosX = 100;
        bool isMoving = false;
        Color playerColor = Color.Cyan;

        Desks drawDesks;

        Walls drawWalls;

        Mouse mouse;
        Cleaner cleaner;
        Apple apple;
        Paper paper;
        Interactables drawInteractables;

        Characters drawCharacters;



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("untitled");
            Window.SetSize(1280,800);
            Window.ClearBackground(Color.OffWhite);



            mouse = new Mouse();
            cleaner = new Cleaner();
            apple = new Apple();
            paper = new Paper();
            Window.SetSize(1280, 800);
            Window.SetTitle("Collision Test");
            Window.TargetFPS = 60;

            drawDesks = new Desks();

            drawWalls = new Walls();

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










            Window.ClearBackground(Color.White);
            //functions below run constantly
            MovementMech();
            PlayerColour();
            //updates player colour
            if (isMoving == false)
            {
                playerColor = Color.Cyan;
            }
            else if (isMoving == true)
            {
                playerColor = Color.Yellow;
            }
            ///draws player
            Draw.FillColor = (playerColor);
            Draw.Circle(playerPosX, playerPosY, 40);
            drawDesks.Update();
            drawWalls.Update();
            drawInteractables.Update();
            drawCharacters.Update();


        }
        //the function that allows the player to move horizontally and diagonally
        public void MovementMech()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.Up) || Input.IsKeyboardKeyDown(KeyboardInput.I))
            {
                playerPosY -= 6;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.Down) || Input.IsKeyboardKeyDown(KeyboardInput.K))
            {
                playerPosY += 6;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.J))
            {
                playerPosX -= 6;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.L))
            {
                playerPosX += 6;
            }
        }
        //the function that makes the player colour change. replace this with sprites
        public void PlayerColour()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.Up) || Input.IsKeyboardKeyDown(KeyboardInput.I))
            {
                isMoving = true;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.Down) || Input.IsKeyboardKeyDown(KeyboardInput.K))
            {
                isMoving = true;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.J))
            {
                isMoving = true;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.L))
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

