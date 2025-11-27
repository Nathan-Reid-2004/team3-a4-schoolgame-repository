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

        //setup and update functions
        public void Setup()
        {

        }

        public void Update()
        {
            DrawInteractableObjects();
        }

        void DrawInteractableObjects()
        {
            //drawing the apple
            applePositionX = 550;
            applePositionY = 600;
            appleWidth = 50;
            appleHeight = 50;

            Draw.FillColor = darkRed;
            Draw.Rectangle(applePositionX, applePositionY, appleWidth, appleHeight);

            //defining apple edges
            float leftEdgeApple = applePositionX;
            float rightEdgeApple = applePositionX + appleWidth;
            float topEdgeApple = applePositionY;
            float bottomEdgeApple = applePositionY + appleHeight;


            //drawing the surface spray
            sprayPositionX = 650;
            sprayPositionY = 125;
            sprayWidth = 50;
            sprayHeight = 50;

            Draw.FillColor = darkRed;
            Draw.Rectangle(sprayPositionX, sprayPositionY, sprayWidth, sprayHeight);

            //defining surface spray edges
            float leftEdgeSpray = sprayPositionX;
            float rightEdgeSpray = sprayPositionX + sprayWidth;
            float topEdgeSpray = sprayPositionY;
            float bottomEdgeSpray = sprayPositionY + sprayHeight;


            //drawing the paper
            paperPositionX = 200;
            paperPositionY = 300;
            paperWidth = 50;
            paperHeight = 50;

            Draw.FillColor = darkRed;
            Draw.Rectangle(paperPositionX, paperPositionY, paperWidth, paperHeight);

            //defining paper edges
            float leftEdgePaper = paperPositionX;
            float rightEdgePaper = paperPositionX + paperWidth;
            float topEdgePaper = paperPositionY;
            float bottomEdgePaper = paperPositionY + paperHeight;


            //drawing the mouse
            mousePositionX = 900;
            mousePositionY = 415;
            mouseWidth = 50;
            mouseHeight = 50;

            Draw.FillColor = darkRed;
            Draw.Rectangle(mousePositionX, mousePositionY, mouseWidth, mouseHeight);

            //defining mouse edges
            float leftEdgeMouse = mousePositionX;
            float rightEdgeMouse = mousePositionX + mouseWidth;
            float topEdgeMouse = mousePositionY;
            float bottomEdgeMouse = mousePositionY + mouseHeight;
        }

    }
}
