using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Mouse
    {
        public Vector2 position;
        Vector2 size;
        Texture2D blackMouse;
        Texture2D inputPrompt;
        float rotation = 0.0f;

        // if mouse is taken

        public bool taken = false;

        // player position
        public Vector2 characterPosition;

        // distance between apple and player
        public float interactionDistance = 50.0f;


        public void Setup()
        {
            blackMouse = Graphics.LoadTexture("MohawkGame2D/Textures/mouse.png");
            inputPrompt = Graphics.LoadTexture("MohawkGame2D/Textures/input_e.png");

            // Mouse position and size
            size = new Vector2(blackMouse.Width, blackMouse.Height);
            position = new Vector2(300, 100);

        }



        public void Update()
        {
            // calculate the distance between player and mouse

            float distance = Vector2.Distance(characterPosition, position);

            bool hover = distance < interactionDistance;


            hover = true;

            // when pressing E to take the mouse

            if (Input.IsKeyboardKeyPressed(KeyboardInput.E))
            {
                taken = true;
            }

            if (!taken)

            // show input prompt when pressing E
            {

                if (hover)
                {
                    Graphics.Rotation = 0.0f;
                    Graphics.Scale = 0.40f;
                    Graphics.Draw(inputPrompt, position + new Vector2(+10, -30));
                }


                
                    rotation += 30.0f * Time.DeltaTime;
                    Graphics.Scale = 0.10f;
                    Graphics.DrawSubset(blackMouse, position + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
                
            }


        }
    }
}

