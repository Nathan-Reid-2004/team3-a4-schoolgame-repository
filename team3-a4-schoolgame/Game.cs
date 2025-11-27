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

        Desks drawDesks;

        Walls drawWalls;

        Mouse mouse;
        Cleaner cleaner;
        Apple apple;
        Paper paper;
        Interactables drawInteractables;

        Characters drawCharacters;

        PlayerCharacter character;



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
           
             Window.ClearBackground(Color.OffWhite);


            drawInteractables = new Interactables();
            drawCharacters = new Characters();
            mouse = new Mouse();
            cleaner = new Cleaner();
            apple = new Apple();
            paper = new Paper();
            Window.SetSize(1280, 800);
            Window.SetTitle("Collision Test");
            Window.TargetFPS = 60;

            drawDesks = new Desks();

            drawWalls = new Walls();

            character = new PlayerCharacter();

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
            










            Window.ClearBackground(Color.White);
            drawDesks.Update(character);
            drawWalls.Update();
            drawInteractables.Update();
            drawCharacters.Update();
            cleaner.Update();
            apple.Update();
            mouse.Update();
            paper.Update();

            character.Update();


        }
        

    }



}

