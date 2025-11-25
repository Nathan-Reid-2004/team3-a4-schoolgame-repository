using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Desks
    {
        //defining variables

        public float deskLeftPositionX;
        public float deskLeftPositionY;
        public float deskLeftWidth;
        public float deskLeftHeight;

        public float deskRightPositionX;
        public float deskRightPositionY;
        public float deskRightWidth;
        public float deskRightHeight;

        public float profDeskPositionX;
        public float profDeskPositionY;
        public float profDeskWidth;
        public float profDeskHeight;

        public float projectorPositionX;
        public float projectorPositionY;
        public float projectorWidth;
        public float projectorHeight;

        public float shelfPositionX;
        public float shelfPositionY;
        public float shelfWidth;
        public float shelfHeight;


        //setup and update functions
        public void Setup()
        {

        }

        public void Update()
        {
            StudentDesks();
            MiscDesksPlusProjector();
        }

        void StudentDesks()
        {
            //drawing all student desks on the left side of the room
            deskLeftPositionX = 150;
            deskLeftWidth = 300;
            deskLeftHeight = 75;

            for (deskLeftPositionY = 200; deskLeftPositionY < 500; deskLeftPositionY += 120)
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(deskLeftPositionX, deskLeftPositionY, deskLeftWidth, deskLeftHeight);
            }

            //drawing all student desks on the right side of the room
            deskRightPositionX = 830;
            deskRightWidth = 300;
            deskRightHeight = 75;

            for (deskRightPositionY = 200; deskRightPositionY < 500; deskRightPositionY += 120)
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(deskRightPositionX, deskRightPositionY, deskRightWidth, deskRightHeight);
            }

        }

        void MiscDesksPlusProjector()
        {
            //drawing professor's desk
            profDeskPositionX = 500;
            profDeskPositionY = 550;
            profDeskWidth = 250;
            profDeskHeight = 75;

            Draw.FillColor = Color.Red;
            Draw.Rectangle(profDeskPositionX, profDeskPositionY, profDeskWidth, profDeskHeight);

            //drawing projectors
            projectorPositionY = 550;
            projectorWidth = 200;
            projectorHeight = 170;

            for (projectorPositionX = 130; projectorPositionX < 1280; projectorPositionX += 830)
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(projectorPositionX, projectorPositionY, projectorWidth, projectorHeight);
            }

            //drawing the shelf at the back of the room
            shelfPositionX = 350;
            shelfPositionY = 75;
            shelfWidth = 400;
            shelfHeight = 75;

            Draw.FillColor = Color.Red;
            Draw.Rectangle(shelfPositionX, shelfPositionY, shelfWidth, shelfHeight);    
        }

    }
}
