using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using main;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        private float screenScaleX;
        private float screenScaleY;
        private ScreenResolution screenResolution;
        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }

        public void ScreenScale()
        {
            screenScaleX = screenResolution.width / camera.scope.X;
            screenScaleY = screenResolution.height / camera.scope.Y;
        }
        public void Draw(Texture2D texture, Rectangle destinationRectangle, SpriteBatch spriteBatch)
        {
            Rectangle cameraRelativeRectangle = new Rectangle(
                camera.scope.X - destinationRectangle.X,
                camera.scope.Y - destinationRectangle.Y,
                destinationRectangle.Width,
                destinationRectangle.Height
            );
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, cameraRelativeRectangle, Color.Black);
            }
        }
    }
}
