using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Walls
    {
        //defining variables
        public float wallPositionX;
        public float wallPositionY;
        public float wallWidth;
        public float wallHeight;

        public float windowPositionX;
        public float windowPositionY;
        public float windowWidth;
        public float windowHeight;

        public float doorPositionX;
        public float doorPositionY;
        public float doorWidth;
        public float doorHeight;


        //collision booleans for each wall
        public bool leftCollisionWall;
        public bool rightCollisionWall;
        public bool topCollisionWall;
        public bool bottomCollisionWall;

        public bool isCollidingWall;


        public bool leftCollisionWindow;
        public bool rightCollisionWindow;
        public bool topCollisionWindow;
        public bool bottomCollisionWindow;

        public bool isCollidingWindow;


        public bool leftCollisionDoor;
        public bool rightCollisionDoor;
        public bool topCollisionDoor;
        public bool bottomCollisionDoor;

        public bool isCollidingDoor;

        //setup and update functions
        public void Setup()
        {

        }

        public void Update(PlayerCharacter character)
        {
            WallsAndWindows(character);
            Door(character);
        }

        void WallsAndWindows(PlayerCharacter character)
        {
            //drawing the front/back walls
            wallPositionX = 0;
            wallWidth = 1280;
            wallHeight = 80;

            for (wallPositionY = 0; wallPositionY < 800; wallPositionY += 720)
            {

                //defining wall edges
                float leftEdgeWall = wallPositionX;
                float rightEdgeWall = wallPositionX + wallWidth;
                float topEdgeWall = wallPositionY;
                float bottomEdgeWall = wallPositionY + wallHeight;


                //making collision detection between the player character hitbox and desk hitboxes
                leftCollisionWall = character.leftEdgePlayer < rightEdgeWall;
                rightCollisionWall = character.rightEdgePlayer > leftEdgeWall;
                topCollisionWall = character.topEdgePlayer < bottomEdgeWall;
                bottomCollisionWall = character.bottomEdgePlayer > topEdgeWall;

                isCollidingWall = leftCollisionWall && rightCollisionWall && topCollisionWall && bottomCollisionWall;

                if (isCollidingWall)
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.DarkGray;
                }
                Draw.Rectangle(wallPositionX, wallPositionY, wallWidth, wallHeight);
            }

            //drawing the windows
            windowPositionY = 0;
            windowWidth = 80;
            windowHeight = 800;

            for (windowPositionX = 0; windowPositionX < 1280; windowPositionX += 1200)
            {

                //defining window edges
                float leftEdgeWindow = windowPositionX;
                float rightEdgeWindow = windowPositionX + windowWidth;
                float topEdgeWindow = windowPositionY;
                float bottomEdgeWindow = windowPositionY + windowHeight;


                //making collision detection between the player character hitbox and desk hitboxes
                leftCollisionWindow = character.leftEdgePlayer < rightEdgeWindow;
                rightCollisionWindow = character.rightEdgePlayer > leftEdgeWindow;
                topCollisionWindow = character.topEdgePlayer < bottomEdgeWindow;
                bottomCollisionWindow = character.bottomEdgePlayer > topEdgeWindow;

                isCollidingWindow = leftCollisionWindow && rightCollisionWindow && topCollisionWindow && bottomCollisionWindow;

                if (isCollidingWindow)
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.DarkGray;
                }
                Draw.Rectangle(windowPositionX, windowPositionY, windowWidth, windowHeight);
            }

        }

        void Door(PlayerCharacter character)
        {
            
            //drawing the door
            doorPositionX = 80;
            doorPositionY = 80;
            doorWidth = 150;
            doorHeight = 100;

            //defining door edges
            float leftEdgeDoor = doorPositionX;
            float rightEdgeDoor = doorPositionX + doorWidth;
            float topEdgeDoor = doorPositionY;
            float bottomEdgeDoor = doorPositionY + doorHeight;


            //making collision detection between the player character hitbox and desk hitboxes
            leftCollisionDoor = character.leftEdgePlayer < rightEdgeDoor;
            rightCollisionDoor = character.rightEdgePlayer > leftEdgeDoor;
            topCollisionDoor = character.topEdgePlayer < bottomEdgeDoor;
            bottomCollisionDoor = character.bottomEdgePlayer > topEdgeDoor;

            isCollidingDoor = leftCollisionDoor && rightCollisionDoor && topCollisionDoor && bottomCollisionDoor;

            if (isCollidingDoor)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = Color.Gray;
            }
            Draw.Rectangle(doorPositionX, doorPositionY, doorWidth, doorHeight);


        }


    }
}
