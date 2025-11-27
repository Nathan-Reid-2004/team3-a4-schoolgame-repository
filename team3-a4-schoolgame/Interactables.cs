using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Interactables
    {
        //defining variables

        Color darkRed = new Color("#800000");
        public float applePositionX;
        public float applePositionY;
        public float appleWidth;
        public float appleHeight;

        public float sprayPositionX;
        public float sprayPositionY;
        public float sprayWidth;
        public float sprayHeight;

        public float paperPositionX;
        public float paperPositionY;
        public float paperWidth;
        public float paperHeight;

        public float mousePositionX;
        public float mousePositionY;
        public float mouseWidth;
        public float mouseHeight;


        //collision booleans for each interactable object
        public bool leftCollisionApple;
        public bool rightCollisionApple;
        public bool topCollisionApple;
        public bool bottomCollisionApple;

        public bool isCollidingApple;


        public bool leftCollisionSpray;
        public bool rightCollisionSpray;
        public bool topCollisionSpray;
        public bool bottomCollisionSpray;

        public bool isCollidingSpray;


        public bool leftCollisionPaper;
        public bool rightCollisionPaper;
        public bool topCollisionPaper;
        public bool bottomCollisionPaper;

        public bool isCollidingPaper;


        public bool leftCollisionMouse;
        public bool rightCollisionMouse;
        public bool topCollisionMouse;
        public bool bottomCollisionMouse;

        public bool isCollidingMouse;


        //setup and update functions
        public void Setup()
        {

        }

        public void Update(PlayerCharacter character)
        {
            DrawInteractableObjects(character);
        }

        void DrawInteractableObjects(PlayerCharacter character)
        {
            //drawing the apple
            applePositionX = 550;
            applePositionY = 600;
            appleWidth = 50;
            appleHeight = 100;

            //defining apple edges
            float leftEdgeApple = applePositionX;
            float rightEdgeApple = applePositionX + appleWidth;
            float topEdgeApple = applePositionY;
            float bottomEdgeApple = applePositionY + appleHeight;


            //making collision detection between the player character hitbox and apple object hitbox
            leftCollisionApple = character.leftEdgePlayer < rightEdgeApple;
            rightCollisionApple = character.rightEdgePlayer > leftEdgeApple;
            topCollisionApple = character.topEdgePlayer < bottomEdgeApple;
            bottomCollisionApple = character.bottomEdgePlayer > topEdgeApple;

            isCollidingApple = leftCollisionApple && rightCollisionApple && topCollisionApple && bottomCollisionApple;

            if (isCollidingApple && (Input.IsKeyboardKeyPressed(KeyboardInput.E)))
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = darkRed;
            }
            Draw.Rectangle(applePositionX, applePositionY, appleWidth, appleHeight);


            //drawing the surface spray
            sprayPositionX = 650;
            sprayPositionY = 125;
            sprayWidth = 50;
            sprayHeight = 100;

            //defining surface spray edges
            float leftEdgeSpray = sprayPositionX;
            float rightEdgeSpray = sprayPositionX + sprayWidth;
            float topEdgeSpray = sprayPositionY;
            float bottomEdgeSpray = sprayPositionY + sprayHeight;


            //making collision detection between the player character hitbox and spray object hitbox
            leftCollisionSpray = character.leftEdgePlayer < rightEdgeSpray;
            rightCollisionSpray = character.rightEdgePlayer > leftEdgeSpray;
            topCollisionSpray = character.topEdgePlayer < bottomEdgeSpray;
            bottomCollisionSpray = character.bottomEdgePlayer > topEdgeSpray;

            isCollidingSpray = leftCollisionSpray && rightCollisionSpray && topCollisionSpray && bottomCollisionSpray;

            if (isCollidingSpray)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = darkRed;
            }
            Draw.Rectangle(sprayPositionX, sprayPositionY, sprayWidth, sprayHeight);


            //drawing the paper
            paperPositionX = 200;
            paperPositionY = 265;
            paperWidth = 50;
            paperHeight = 100;

            //defining paper edges
            float leftEdgePaper = paperPositionX;
            float rightEdgePaper = paperPositionX + paperWidth;
            float topEdgePaper = paperPositionY;
            float bottomEdgePaper = paperPositionY + paperHeight;


            //making collision detection between the player character hitbox and paper object hitbox
            leftCollisionPaper = character.leftEdgePlayer < rightEdgePaper;
            rightCollisionPaper = character.rightEdgePlayer > leftEdgePaper;
            topCollisionPaper = character.topEdgePlayer < bottomEdgePaper;
            bottomCollisionPaper = character.bottomEdgePlayer > topEdgePaper;

            isCollidingPaper = leftCollisionPaper && rightCollisionPaper && topCollisionPaper && bottomCollisionPaper;

            if (isCollidingPaper)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = darkRed;
            }
            Draw.Rectangle(paperPositionX, paperPositionY, paperWidth, paperHeight);


            //drawing the mouse
            mousePositionX = 900;
            mousePositionY = 385;
            mouseWidth = 50;
            mouseHeight = 100;

            //defining mouse edges
            float leftEdgeMouse = mousePositionX;
            float rightEdgeMouse = mousePositionX + mouseWidth;
            float topEdgeMouse = mousePositionY;
            float bottomEdgeMouse = mousePositionY + mouseHeight;


            //making collision detection between the player character hitbox mouse object hitbox
            leftCollisionMouse = character.leftEdgePlayer < rightEdgeMouse;
            rightCollisionMouse = character.rightEdgePlayer > leftEdgeMouse;
            topCollisionMouse = character.topEdgePlayer < bottomEdgeMouse;
            bottomCollisionMouse = character.bottomEdgePlayer > topEdgeMouse;

            isCollidingMouse = leftCollisionMouse && rightCollisionMouse && topCollisionMouse && bottomCollisionMouse;

            if (isCollidingMouse)
            {
                Draw.FillColor = Color.Green;
            }
            else
            {
                Draw.FillColor = darkRed;
            }
            Draw.Rectangle(mousePositionX, mousePositionY, mouseWidth, mouseHeight);
        }

    }
}
