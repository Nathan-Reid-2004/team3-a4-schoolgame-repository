using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class PlayerCharacter
    {
        //defining variables
        public float playerPosY = 100;
        public float playerPosX = 250;
        float playerWidth = 25;
        float playerHeight = 25;
        public bool canMoveLeft = true;
        public bool canMoveRight = true;
        public bool canMoveDown = true;
        public bool canMoveUp = true;
        bool isMoving = false;
        Color playerColor = Color.Cyan;

        public float leftEdgePlayer;
        public float rightEdgePlayer;
        public float topEdgePlayer;
        public float bottomEdgePlayer;

        //setup and update functions
        public void Setup()
        {

        }

        public void Update()
        {

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

            //draws player
            Draw.FillColor = (playerColor);

            Draw.Rectangle(playerPosX, playerPosY, playerWidth, playerHeight);

            //defining player character edges
            leftEdgePlayer = playerPosX;
            rightEdgePlayer = playerPosX + playerWidth;
            topEdgePlayer = playerPosY;
            bottomEdgePlayer = playerPosY + playerHeight;
        }

        //the function that allows the player to move horizontally and diagonally
        public void MovementMech()
        {
            if (canMoveUp == true && Input.IsKeyboardKeyDown(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.Up) || Input.IsKeyboardKeyDown(KeyboardInput.I))
            {
                playerPosY -= 6;
            }
            if (canMoveDown == true && Input.IsKeyboardKeyDown(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.Down) || Input.IsKeyboardKeyDown(KeyboardInput.K))
            {
                playerPosY += 6;
            }
            if (canMoveLeft == true && Input.IsKeyboardKeyDown(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.J))
            {
                playerPosX -= 6;
            }
            if (canMoveRight == true && Input.IsKeyboardKeyDown(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.L))
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
