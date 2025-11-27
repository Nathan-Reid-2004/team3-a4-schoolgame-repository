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


        //collision booleans for each object
        public bool leftCollisionDeskLeft;
        public bool rightCollisionDeskLeft;
        public bool topCollisionDeskLeft;
        public bool bottomCollisionDeskLeft;

        public bool isCollidingDeskLeft;


        public bool leftCollisionDeskRight;
        public bool rightCollisionDeskRight;
        public bool topCollisionDeskRight;
        public bool bottomCollisionDeskRight;

        public bool isCollidingDeskRight;


        public bool leftCollisionProfDesk;
        public bool rightCollisionProfDesk;
        public bool topCollisionProfDesk;
        public bool bottomCollisionProfDesk;

        public bool isCollidingProfDesk;


        public bool leftCollisionProjector;
        public bool rightCollisionProjector;
        public bool topCollisionProjector;
        public bool bottomCollisionProjector;

        public bool isCollidingProjector;


        public bool leftCollisionShelf;
        public bool rightCollisionShelf;
        public bool topCollisionShelf;
        public bool bottomCollisionShelf;

        public bool isCollidingShelf;


        //setup and update functions
        public void Setup()
        {

        }

        public void Update(PlayerCharacter character)
        {
            StudentDesks(character);
            MiscDesksPlusProjector(character);
        }

        void StudentDesks(PlayerCharacter character)
        {
            //drawing all student desks on the left side of the room
            deskLeftPositionX = 150;
            deskLeftWidth = 300;
            deskLeftHeight = 60;

            for (deskLeftPositionY = 200; deskLeftPositionY < 500; deskLeftPositionY += 120)
            {

                //defining left-side student desks edges
                float leftEdgeDeskLeft = deskLeftPositionX;
                float rightEdgeDeskLeft = deskLeftPositionX + deskLeftWidth;
                float topEdgeDeskLeft = deskLeftPositionY;
                float bottomEdgeDeskLeft = deskLeftPositionY + deskLeftHeight;

                
                //making collision detection between the player character hitbox and desk hitboxes
                leftCollisionDeskLeft = character.leftEdgePlayer < rightEdgeDeskLeft;
                rightCollisionDeskLeft = character.rightEdgePlayer > leftEdgeDeskLeft;
                topCollisionDeskLeft = character.topEdgePlayer < bottomEdgeDeskLeft;
                bottomCollisionDeskLeft = character.bottomEdgePlayer > topEdgeDeskLeft;

                isCollidingDeskLeft = leftCollisionDeskLeft && rightCollisionDeskLeft && topCollisionDeskLeft && bottomCollisionDeskLeft;

                if (isCollidingDeskLeft)
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Red;
                }
                Draw.Rectangle(deskLeftPositionX, deskLeftPositionY, deskLeftWidth, deskLeftHeight);


            }

            //drawing all student desks on the right side of the room
            deskRightPositionX = 830;
            deskRightWidth = 300;
            deskRightHeight = 60;

            for (deskRightPositionY = 200; deskRightPositionY < 500; deskRightPositionY += 120)
            {

                //defining right-side student desks edges
                float leftEdgeDeskRight = deskRightPositionX;
                float rightEdgeDeskRight = deskRightPositionX + deskRightWidth;
                float topEdgeDeskRight = deskRightPositionY;
                float bottomEdgeDeskRight = deskRightPositionY + deskRightHeight;


                //making collision detection between the player character hitbox and desk hitboxes
                leftCollisionDeskRight = character.leftEdgePlayer < rightEdgeDeskRight;
                rightCollisionDeskRight = character.rightEdgePlayer > leftEdgeDeskRight;
                topCollisionDeskRight = character.topEdgePlayer < bottomEdgeDeskRight;
                bottomCollisionDeskRight = character.bottomEdgePlayer > topEdgeDeskRight;

                isCollidingDeskRight = leftCollisionDeskRight && rightCollisionDeskRight && topCollisionDeskRight && bottomCollisionDeskRight;

                if (isCollidingDeskRight)
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Red;
                }
                Draw.Rectangle(deskRightPositionX, deskRightPositionY, deskRightWidth, deskRightHeight);
            }

        }

        void MiscDesksPlusProjector(PlayerCharacter character)
        {
            //drawing professor's desk
            profDeskPositionX = 500;
            profDeskPositionY = 550;
            profDeskWidth = 250;
            profDeskHeight = 75;

            //defining prof desk edges
            float leftEdgeProfDesk = profDeskPositionX;
            float rightEdgeProfDesk = profDeskPositionX + profDeskWidth;
            float topEdgeProfDesk = profDeskPositionY;
            float bottomEdgeProfDesk = profDeskPositionY + profDeskHeight;


            //making collision detection between the player character hitbox and prof desk hitbox
            leftCollisionProfDesk = character.leftEdgePlayer < rightEdgeProfDesk;
            rightCollisionProfDesk = character.rightEdgePlayer > leftEdgeProfDesk;
            topCollisionProfDesk = character.topEdgePlayer < bottomEdgeProfDesk;
            bottomCollisionProfDesk = character.bottomEdgePlayer > topEdgeProfDesk;

            isCollidingProfDesk = leftCollisionProfDesk && rightCollisionProfDesk && topCollisionProfDesk && bottomCollisionProfDesk;

            if (isCollidingProfDesk)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = Color.Red;
            }
            Draw.Rectangle(profDeskPositionX, profDeskPositionY, profDeskWidth, profDeskHeight);



            //drawing projectors
            projectorPositionY = 550;
            projectorWidth = 200;
            projectorHeight = 170;

            for (projectorPositionX = 130; projectorPositionX < 1280; projectorPositionX += 830)
            {

                //defining projector edges
                float leftEdgeProjector = projectorPositionX;
                float rightEdgeProjector = projectorPositionX + projectorWidth;
                float topEdgeProjector = projectorPositionY;
                float bottomEdgeProjector = projectorPositionY + projectorHeight;


                //making collision detection between the player character hitbox and projector hitboxes
                leftCollisionProjector = character.leftEdgePlayer < rightEdgeProjector;
                rightCollisionProjector = character.rightEdgePlayer > leftEdgeProjector;
                topCollisionProjector = character.topEdgePlayer < bottomEdgeProjector;
                bottomCollisionProjector = character.bottomEdgePlayer > topEdgeProjector;

                isCollidingProjector = leftCollisionProjector && rightCollisionProjector && topCollisionProjector && bottomCollisionProjector;

                if (isCollidingProjector)
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Red;
                }
                Draw.Rectangle(projectorPositionX, projectorPositionY, projectorWidth, projectorHeight);

            }

            //drawing the shelf at the back of the room
            shelfPositionX = 350;
            shelfPositionY = 75;
            shelfWidth = 400;
            shelfHeight = 75;

            //defining shelf edges
            float leftEdgeShelf = shelfPositionX;
            float rightEdgeShelf = shelfPositionX + shelfWidth;
            float topEdgeShelf = shelfPositionY;
            float bottomEdgeShelf = shelfPositionY + shelfHeight;


            //making collision detection between the player character hitbox and shelf hitbox
            leftCollisionShelf = character.leftEdgePlayer < rightEdgeShelf;
            rightCollisionShelf = character.rightEdgePlayer > leftEdgeShelf;
            topCollisionShelf = character.topEdgePlayer < bottomEdgeShelf;
            bottomCollisionShelf = character.bottomEdgePlayer > topEdgeShelf;

            isCollidingShelf = leftCollisionShelf && rightCollisionShelf && topCollisionShelf && bottomCollisionShelf;

            if (isCollidingShelf)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = Color.Red;
            }
            Draw.Rectangle(shelfPositionX, shelfPositionY, shelfWidth, shelfHeight);
        }

    }
}
