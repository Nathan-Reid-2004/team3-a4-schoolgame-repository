using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Paper
    {
        public Vector2 position;
        Vector2 size;
        Texture2D crumbledPaper;
        Texture2D inputPrompt;
        float rotation = 0.0f;

        // if paper is taken 
        public bool taken = false;

        // player position
        public Vector2 characterPosition;

        // distance between apple and player
        public float interactionDistance = 50.0f;


        public void Setup()
        {
            crumbledPaper = Graphics.LoadTexture("MohawkGame2D/crumpled_paper.png");
            inputPrompt = Graphics.LoadTexture("MohawkGame2D/Textures/input_e.png");

            // Paper position and size
            size = new Vector2(crumbledPaper.Width, crumbledPaper.Height);
            position = new Vector2(250, 400);



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
                Graphics.DrawSubset(crumbledPaper, position + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);




            }
        }
    }
}
