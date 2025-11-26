using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Cleaner
    {
        public Vector2 position;
        Vector2 size;
        Texture2D surfaceCleaner;
        Texture2D inputPrompt;
        float rotation = 0.0f;

        public float leftEdge = 0.0f;
        public float rightEdge = 0.0f;
        public float topEdge = 0.0f;
        public float bottomEdge = 0.0f;

        // if cleaner is taken
        public bool taken = false;

        // player position
        public Vector2 characterPosition;

        // distance between apple and player
        public float interactionDistance = 50.0f;



        public void Setup()
        {
            surfaceCleaner = Graphics.LoadTexture("MohawkGame2D/Textures/surface_cleaner.png");
            inputPrompt = Graphics.LoadTexture("MohawkGame2D/Textures/input_e.png");

            // Cleaner position and size

            size = new Vector2(surfaceCleaner.Width, surfaceCleaner.Height);
            position = new Vector2(150, 300);


        }
        public void Update()
        {
            // Calculate the distance between player and paper 

            float distance = Vector2.Distance(characterPosition, position);

            bool hover = distance < interactionDistance;

            hover = true;

            // when pressing E to take the mouse       

            if (Input.IsKeyboardKeyPressed(KeyboardInput.E))
            {
                taken = true;
            }

            if (!taken)

            // show the input prompt when pressing E 

            {
                if (hover)
                {
                    Graphics.Rotation = 0.0f;
                    Graphics.Scale = 0.40f;
                    Graphics.Draw(inputPrompt, position + new Vector2(+10, -30));
                }



                rotation += 30.0f * Time.DeltaTime;
                Graphics.Scale = 0.10f;
                Graphics.DrawSubset(surfaceCleaner, position + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
            }

        }

    }
}
