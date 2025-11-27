using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Characters
    {
        //defining variables (C1 = Character 1, C2 = Character 2, etc.)

        Color limeGreen = new Color("#32CD32");

        public float C1PositionX;
        public float C1PositionY;
        public float C1Width;
        public float C1Height;

        public float C2PositionX;
        public float C2PositionY;
        public float C2Width;
        public float C2Height;

        public float C3PositionX;
        public float C3PositionY;
        public float C3Width;
        public float C3Height;

        public float C4PositionX;
        public float C4PositionY;
        public float C4Width;
        public float C4Height;


        //collision booleans for each character NPC
        public bool leftCollisionC1;
        public bool rightCollisionC1;
        public bool topCollisionC1;
        public bool bottomCollisionC1;

        public bool isCollidingC1;


        public bool leftCollisionC2;
        public bool rightCollisionC2;
        public bool topCollisionC2;
        public bool bottomCollisionC2;

        public bool isCollidingC2;


        public bool leftCollisionC3;
        public bool rightCollisionC3;
        public bool topCollisionC3;
        public bool bottomCollisionC3;

        public bool isCollidingC3;


        public bool leftCollisionC4;
        public bool rightCollisionC4;
        public bool topCollisionC4;
        public bool bottomCollisionC4;

        public bool isCollidingC4;



        //setup and update functions
        public void Setup()
        {

        }

        public void Update(PlayerCharacter character)
        {

            DrawCharacterNPCs(character);

        }

        void DrawCharacterNPCs(PlayerCharacter character)
        {
            //drawing Character 1
            C1PositionX = 650;
            C1PositionY = 400;
            C1Width = 150;
            C1Height = 25;

            //defining Character 1 edges
            float leftEdgeC1 = C1PositionX;
            float rightEdgeC1 = C1PositionX + C1Width;
            float topEdgeC1 = C1PositionY;
            float bottomEdgeC1 = C1PositionY + C1Height;


            //making collision detection between the player character hitbox and C1 hitbox
            leftCollisionC1 = character.leftEdgePlayer < rightEdgeC1;
            rightCollisionC1 = character.rightEdgePlayer > leftEdgeC1;
            topCollisionC1 = character.topEdgePlayer < bottomEdgeC1;
            bottomCollisionC1 = character.bottomEdgePlayer > topEdgeC1;

            isCollidingC1 = leftCollisionC1 && rightCollisionC1 && topCollisionC1 && bottomCollisionC1;

            if (isCollidingC1)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = limeGreen;
            }
            Draw.Rectangle(C1PositionX, C1PositionY, C1Width, C1Height);


            //drawing Character 2
            C2PositionX = 1010;
            C2PositionY = 125;
            C2Width = 150;
            C2Height = 25;

            //defining Character 2 edges
            float leftEdgeC2 = C2PositionX;
            float rightEdgeC2 = C2PositionX + C2Width;
            float topEdgeC2 = C2PositionY;
            float bottomEdgeC2 = C2PositionY + C2Height;


            //making collision detection between the player character hitbox and C2 hitbox
            leftCollisionC2 = character.leftEdgePlayer < rightEdgeC2;
            rightCollisionC2 = character.rightEdgePlayer > leftEdgeC2;
            topCollisionC2 = character.topEdgePlayer < bottomEdgeC2;
            bottomCollisionC2 = character.bottomEdgePlayer > topEdgeC2;

            isCollidingC2 = leftCollisionC2 && rightCollisionC2 && topCollisionC2 && bottomCollisionC2;

            if (isCollidingC2)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = limeGreen;
            }
            Draw.Rectangle(C2PositionX, C2PositionY, C2Width, C2Height);


            //drawing Character 3
            C3PositionX = 250;
            C3PositionY = 165;
            C3Width = 150;
            C3Height = 25;

            //defining Character 3 edges
            float leftEdgeC3 = C3PositionX;
            float rightEdgeC3 = C3PositionX + C3Width;
            float topEdgeC3 = C3PositionY;
            float bottomEdgeC3 = C3PositionY + C3Height;


            //making collision detection between the player character hitbox and C3 hitbox
            leftCollisionC3 = character.leftEdgePlayer < rightEdgeC3;
            rightCollisionC3 = character.rightEdgePlayer > leftEdgeC3;
            topCollisionC3 = character.topEdgePlayer < bottomEdgeC3;
            bottomCollisionC3 = character.bottomEdgePlayer > topEdgeC3;

            isCollidingC3 = leftCollisionC3 && rightCollisionC3 && topCollisionC3 && bottomCollisionC3;

            if (isCollidingC3)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = limeGreen;
            }
            Draw.Rectangle(C3PositionX, C3PositionY, C3Width, C3Height);


            //drawing Character 4
            C4PositionX = 625;
            C4PositionY = 650;
            C4Width = 150;
            C4Height = 25;

            //defining Character 4 edges
            float leftEdgeC4 = C4PositionX;
            float rightEdgeC4 = C4PositionX + C4Width;
            float topEdgeC4 = C4PositionY;
            float bottomEdgeC4 = C4PositionY + C4Height;


            //making collision detection between the player character hitbox and C4 hitbox
            leftCollisionC4 = character.leftEdgePlayer < rightEdgeC4;
            rightCollisionC4 = character.rightEdgePlayer > leftEdgeC4;
            topCollisionC4 = character.topEdgePlayer < bottomEdgeC4;
            bottomCollisionC4 = character.bottomEdgePlayer > topEdgeC4;

            isCollidingC4 = leftCollisionC4 && rightCollisionC4 && topCollisionC4 && bottomCollisionC4;

            if (isCollidingC4)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = limeGreen;
            }

            Draw.Rectangle(C4PositionX, C4PositionY, C4Width, C4Height);

            
        }
    }




}

