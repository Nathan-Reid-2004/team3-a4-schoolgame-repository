using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Npc
    {
        public Vector2 position;
        public Vector2 position1;
        public Vector2 position2;
        public Vector2 position3;
        Vector2 size;
        Texture2D char2;
        Texture2D char3;
        Texture2D teacher;
        float rotation = 0.0f;
        public void Setup()
        {
            char2 = Graphics.LoadTexture("MohawkGame2D/Textures/char2.png");
            char3 = Graphics.LoadTexture("MohawkGame2D/Textures/char3.png");
            teacher = Graphics.LoadTexture("MohawkGame2D/Textures/teacher.png");
           

            
            // char2 position and size
            size = new Vector2(char2.Width, char2.Height);
            position1 = new Vector2(990, 30);
            // char3 position and size 
            size = new Vector2(char3.Width, char3.Height);
            position2 = new Vector2(620, 300);
            // teacher position and size 
            size = new Vector2(teacher.Width, teacher.Height);
            position3 = new Vector2(600, 560);

        }
        public void Update()
        {
            
            // draw char2
            Graphics.DrawSubset(char2, position1 + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
            // draw char3
            Graphics.DrawSubset(char3, position2 + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
            // draw teacher
            Graphics.DrawSubset(teacher, position3 + size / 2.0f, new Vector2(0, 0), size, size / 2.0f);
        }
    }
}

            
