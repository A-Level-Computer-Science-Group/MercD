using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        private SpriteBatch spriteBatch;

        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }

        public void Draw(Texture2D texture, Rectangle destinationRectangle)
        {
            Rectangle positionDifference = destinationRectangle; 
            positionDifference.X = camera.scope.X - destinationRectangle.X;
            positionDifference.Y = camera.scope.Y - destinationRectangle.Y;
            spriteBatch.Begin();
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, positionDifference, Color.Black);
            }
            spriteBatch.End();
        }
    }
}
