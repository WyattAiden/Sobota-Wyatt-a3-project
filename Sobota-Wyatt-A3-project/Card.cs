using System;
using System.Numerics;

namespace Game10003
{
    public class Card
    {
        private float W;
        private float H;
        public float X;
        public float Y;


        public Card()
        {
            W = 50;
            H = 80;
            
        }


        private void CardFront()
        {
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(X, Y, W, H);
        }
        private void CardBack()
        {
            Draw.FillColor = Color.Red;
            Draw.Rectangle(X, Y, W, H);
        }
    }
}
