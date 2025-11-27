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

        public bool isCollidingC4;

        public bool hasInteracted = false;

        public bool taken = false;

        public void update()
        {
            TeacherInteraction();
        }

        void TeacherInteraction()
        {




            if (!(isCollidingC4) && (taken = false))
            {
                hasInteracted = true;
            }

            if (hasInteracted)
            {
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.Red;
                Draw.Rectangle(0, 660, 1280, 800);

                Text.Draw("Hey, great timing!\nClass is just about to start and I can't find my mouse anywhere!\nPlease help me find it!", 40, 680);

            }

            if (!(isCollidingC4 = false) || (taken = true))
            {
                hasInteracted = false;
            }
            
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                taken = true;
            }

            if (taken && isCollidingC4)
            {
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.Red;
                Draw.Rectangle(0, 660, 1280, 800);

                Text.Draw("You found it!\nThank you so much!!\nYou'll get an extra 10 marks on your next text ;)", 40, 680);
            }
        }



    }
}
