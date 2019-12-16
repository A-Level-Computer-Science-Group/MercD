using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace main
{
    public class ScreenResolution
    {
        private int height;
        private int width;
        // Prints width and height of windows
        public void Update(GameWindow window)
        {
            height = window.ClientBounds.Height;
            width = window.ClientBounds.Width;
        }

        public int widthD
        {
            get{return width;}
            set{}
        }
        public int heightD
        {
            get{return height;}
            set{}
        }

        public void Resolution()
        {
            Console.WriteLine($"Width:{width} Height:{height}");
        }
    }
}