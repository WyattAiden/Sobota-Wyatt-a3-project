// Include code libraries you need below (use the namespace).
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Deck PlaceDeck;

        Vector2[] Positions = new Vector2[12];
        Card[] cards = new Card[12];
        public void Setup()
        {
            Window.SetTitle("Concentration");
            Window.SetSize(400, 400);

            // Define the 6 colors and duplicate them to have pairs
            List<Color> colors = new List<Color>
            {
                Color.Blue, Color.Green, Color.Yellow, Color.Cyan, Color.Magenta, Color.Black
            };

            // Duplicate each color to make pairs
            List<Color> colorPairs = new List<Color>();
            foreach (Color color in colors)
            {
                colorPairs.Add(color);
                colorPairs.Add(color);
            }

            // Shuffle the list of colors
            System.Random rand = new System.Random();
            for (int i = 0; i < colorPairs.Count; i++)
            {
                int randomIndex = rand.Next(i, colorPairs.Count);
                Color temp = colorPairs[i];
                colorPairs[i] = colorPairs[randomIndex];
                colorPairs[randomIndex] = temp;
            }

            //making the aray to make the cards
            for (int i = 0; i < 4; i++)
            {
                int x = i * 70 + 20;
                for (int j = 0; j < 3; j++)
                {
                    int y = j * 100 + 50;
                    int inex = i + j * 4;
                    Positions[inex] = new Vector2(x, y);
                    cards[inex] = new Card(x,y);
                    cards[inex] = new Card(x, y, colorPairs[inex]);
                }
            }
            
            PlaceDeck = new Deck();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            
            foreach (Card card in cards)
            {
                card.Update();
            }
            PlaceDeck.Update();
        }
    }
}
