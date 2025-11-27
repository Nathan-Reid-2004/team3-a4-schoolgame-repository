using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace team3_a4_schoolgame
{
    
    public class Dialogue
    {
        public float radius = 50.0f;
        public Vector2 position = new Vector2(40, 40);
        
        bool itemObtained = false;
        
        public void update()
        {
            Draw.LineColor = Color.Black;
            Draw.Circle(position, radius);
        }

        void ProcessInputs()
        {
            Vector2 mouseInsideCircle = Input.GetMousePosition() - position;
            bool insideCircle = mouseInsideCircle.Length() < radius;

            if (insideCircle && Input.IsMouseButtonPressed(MouseInput.Left))
            {
                itemObtained = true;
            }
        }


    }
}
