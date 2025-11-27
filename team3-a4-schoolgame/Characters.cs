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


        //setup and update functions
        public void Setup()
        {

        }

        public void Update()
        {

            DrawCharacterNPCs();

        }

        void DrawCharacterNPCs()
        {
            //drawing Character 1
            C1PositionX = 650;
            C1PositionY = 400;
            C1Width = 150;
            C1Height = 25;

            Draw.FillColor = limeGreen;
            Draw.Rectangle(C1PositionX, C1PositionY, C1Width, C1Height);

            //defining Character 1 edges
            float leftEdgeC1 = C1PositionX;
            float rightEdgeC1 = C1PositionX + C1Width;
            float topEdgeC1 = C1PositionY;
            float bottomEdgeC1 = C1PositionY + C1Height;


            //drawing Character 2
            C2PositionX = 1010;
            C2PositionY = 125;
            C2Width = 150;
            C2Height = 25;

            Draw.FillColor = limeGreen;
            Draw.Rectangle(C2PositionX, C2PositionY, C2Width, C2Height);

            //defining Character 2 edges
            float leftEdgeC2 = C2PositionX;
            float rightEdgeC2 = C2PositionX + C2Width;
            float topEdgeC2 = C2PositionY;
            float bottomEdgeC2 = C2PositionY + C2Height;


            //drawing Character 3
            C3PositionX = 250;
            C3PositionY = 165;
            C3Width = 150;
            C3Height = 25;

            Draw.FillColor = limeGreen;
            Draw.Rectangle(C3PositionX, C3PositionY, C3Width, C3Height);

            //defining Character 3 edges
            float leftEdgeC3 = C3PositionX;
            float rightEdgeC3 = C3PositionX + C3Width;
            float topEdgeC3 = C3PositionY;
            float bottomEdgeC3 = C3PositionY + C3Height;


            //drawing Character 4
            C4PositionX = 625;
            C4PositionY = 650;
            C4Width = 150;
            C4Height = 25;

            Draw.FillColor = limeGreen;
            Draw.Rectangle(C4PositionX, C4PositionY, C4Width, C4Height);

            //defining Character 4 edges
            float leftEdgeC4 = C4PositionX;
            float rightEdgeC4 = C4PositionX + C4Width;
            float topEdgeC4 = C4PositionY;
            float bottomEdgeC4 = C4PositionY + C4Height;
        }




    }
}
