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
        public float radius = 50.0f;
        public Vector2 position = new Vector2(40, 40);

        Desks drawDesks;
        bool itemObtained = false;

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

            










            Window.ClearBackground(Color.White);
            drawDesks.Update(character);
            drawWalls.Update(character);
            drawInteractables.Update(character);
            drawCharacters.Update(character);
            cleaner.Update();
            apple.Update();
            mouse.Update();
            paper.Update();

            character.Update();


            if (insideCircle && Input.IsMouseButtonPressed(MouseInput.Left))
            {
                itemObtained = true;
            }
        }
        

    }



}

