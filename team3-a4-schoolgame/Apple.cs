using Microsoft.VisualBasic;
using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Apple
    {
        public Vector2 position;
        Vector2 size;
        Texture2D modlyApple;
        Texture2D inputPrompt;
        float rotation = 0.0f;

        // if apple is taken
        public bool taken = false;

        // player position
        public Vector2 characterPosition;
        // distance between apple and player
        public float interactionDistance = 50.0f;


        public void Setup()
        {
            modlyApple = Graphics.LoadTexture("MohawkGame2D/Textures/moldy_apple.png");
            inputPrompt = Graphics.LoadTexture("MohawkGame2D/Textures/input_e.png");

            // Apple position & size
            position = new Vector2(400, 300);
            size = new Vector2(modlyApple.Width, modlyApple.Height);

        }
        public void Update()
        {

            // calculate distance between apple and player

            float distance = Vector2.Distance(characterPosition, position);

            bool hover = distance < interactionDistance;


            hover = true;
            // when pressing E to take the apple
            if (Input.IsKeyboardKeyPressed(KeyboardInput.E))
            {
                taken = true;
            }

            if (!taken)
                //show input prompt when pressing E
            {
                if (hover)
                {

                    Graphics.Rotation = 0.0f;
                    Graphics.Scale = 0.40f;
                    Graphics.Draw(inputPrompt, position + new Vector2(+10, -30));
                }
        

     
                rotation += 30.0f * Time.DeltaTime;
                Graphics.Scale = 0.10f;
                Graphics.DrawSubset(modlyApple, position + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
            }
        }
    }

 }


