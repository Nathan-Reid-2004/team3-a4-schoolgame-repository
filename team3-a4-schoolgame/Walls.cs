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

        //setup and update functions

        public void Setup()
        {

        }

        public void Update()
        {
            WallsAndWindows();
            Door();
        }

        void WallsAndWindows()
        {
            //drawing the front/back walls
            wallPositionX = 0;
            wallWidth = 1280;
            wallHeight = 80;

            for (wallPositionY = 0; wallPositionY < 800; wallPositionY += 720)
            {
                Draw.FillColor = Color.DarkGray;
                Draw.Rectangle(wallPositionX, wallPositionY, wallWidth, wallHeight);

                //defining wall edges
                float leftEdgeWall = wallPositionX;
                float rightEdgeWall = wallPositionX + wallWidth;
                float topEdgeWall = wallPositionY;
                float bottomEdgeWall = wallPositionY + wallHeight;
            }

            //drawing the windows
            windowPositionY = 0;
            windowWidth = 80;
            windowHeight = 800;

            for (windowPositionX = 0; windowPositionX < 1280; windowPositionX += 1200)
            {
                Draw.FillColor = Color.DarkGray;
                Draw.Rectangle(windowPositionX, windowPositionY, windowWidth, windowHeight);

                //defining window edges
                float leftEdgeWindow = windowPositionX;
                float rightEdgeWindow = windowPositionX + windowWidth;
                float topEdgeWindow = windowPositionY;
                float bottomEdgeWindow = windowPositionY + windowHeight;
            }

        }

        void Door()
        {
            
            //drawing the door
            doorPositionX = 80;
            doorPositionY = 80;
            doorWidth = 150;
            doorHeight = 100;

            Draw.FillColor = Color.Gray;
            Draw.Rectangle(doorPositionX, doorPositionY, doorWidth, doorHeight);

            //defining door edges
            float leftEdgeDoor = doorPositionX;
            float rightEdgeDoor = doorPositionX + doorWidth;
            float topEdgeDoor = doorPositionY;
            float bottomEdgeDoor = doorPositionY + doorHeight;

        }


    }
}
