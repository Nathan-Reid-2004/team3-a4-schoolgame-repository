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

        public float leftEdge = 0.0f;
        public float rightEdge = 0.0f;
        public float topEdge = 0.0f;
        public float bottomEdge = 0.0f;

        public bool taken = false;
 
    
    public void Setup()
        {
            modlyApple = Graphics.LoadTexture("Textures/moldy_apple.png");
            size = new Vector2(modlyApple.Width, modlyApple.Height);

            inputPrompt = Graphics.LoadTexture("Textures/input_e.png");
        }
        public void Update(Apple apple )
        {
            leftEdge = position.X;
            rightEdge = position.X + size.X;
            topEdge = position.Y;
            bottomEdge = position.Y + size.Y;

            bool hover = false;

            if (rightEdge > apple.leftEdge && leftEdge < apple.rightEdge
                && bottomEdge > apple.topEdge && topEdge < apple.bottomEdge)
            {
                hover = true;
                if (Input.IsKeyboardKeyPressed(KeyboardInput.E))
                {
                    taken = true;
                }
            }
            if (!taken)

            // show the input prompt when pressing E

            {
                if (hover)
                    Graphics.Rotation = 0.0f;
                Graphics.Scale = 0.50f;
                Graphics.Draw(inputPrompt, position + new Vector2(+10, -30));
            }

            rotation += 30.0f * Time.DeltaTime;
            Graphics.Rotation = rotation;
            Graphics.Scale = 1.0f;
            Graphics.DrawSubset(modlyApple, position + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
        }
    }

}