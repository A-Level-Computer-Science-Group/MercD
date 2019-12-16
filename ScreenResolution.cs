using System;
using Microsoft.Xna.Framework;
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

        public void Resolution()
        {
            Console.WriteLine($"Width:{width} Height:{height}");
        }
    }
}