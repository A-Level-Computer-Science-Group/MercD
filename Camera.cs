using Microsoft.Xna.Framework;
namespace Camera
{
    public class Camera
    {
        private int width;
        private int height;

        public Camera(int width, int height)
        {
            this.width = width;
            this.height = height;

            Rectangle rectangle = new Rectangle(0, 0, width, height);
        }
    }
}