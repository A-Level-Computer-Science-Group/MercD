using System;
using Microsoft.Xna.Framework;
namespace main
{
    public class ScreenResolution
    {
        public int height { get; private set; }
        public int width { get; private set; }
        public void Update(GameWindow window)
        {
            height = window.ClientBounds.Height;
            width = window.ClientBounds.Width;
        }

        public void ConsoleWrite()
        {
            // Prints width and height of windows
            Console.WriteLine($"Width:{width} Height:{height}");
        }
    }
}